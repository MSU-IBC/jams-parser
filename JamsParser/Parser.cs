using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace JamsParser
{
    public class Parser
    {
        private const int PageSize = 100;
        private readonly string _rootUrl;
        private readonly string _apiKey;
        private readonly DomainDataContext _database;
        private const string Pam = "{http://prismstandard.org/namespaces/pam/2.0/}";
	    private const string Dc = "{http://purl.org/dc/elements/1.1/}";
	    private const string Prism = "{http://prismstandard.org/namespaces/basic/2.0/}";
	    private const string Xhtml = "{http://www.w3.org/1999/xhtml}";

        public Parser(string rootUrl, string apiKey)
        {
            _rootUrl = rootUrl;
            _apiKey = apiKey;
            _database = new DomainDataContext();
        }

        public void Execute(Query query)
        {
            foreach (var doi in GetDois(_rootUrl + "?q=" + query.Build() + "&api_key=" + _apiKey))
            {
                var art= _database.Articles.SingleOrDefault(a => a.DOI == doi);

                if (art == null)
                {
                    art = new Article();
                    _database.Articles.InsertOnSubmit(art);
                }

                FillArticle(art, _rootUrl + "?q=doi:" + doi + "&api_key=" + _apiKey);
            }

            _database.SubmitChanges();
        }

        private int GetPageCount(string url)
        {
            using (var stream = WebRequest.Create(url + "&p=1&s=1").GetResponse().GetResponseStream())
            {
                return (XElement.Load(stream).Descendants("result").Select(r => (int)r.Element("total")).Single() + PageSize - 1) / 100;
            }
        }

        private IEnumerable<string> GetDois(string url)
        {
            var dois = new List<string>();

            foreach (var page in Enumerable.Range(1, GetPageCount(url)))
            {
                using (var stream = WebRequest.Create(url + "&p=" + PageSize + "&s=" + ((page - 1) * PageSize + 1)).GetResponse().GetResponseStream())
                {
                    dois.AddRange(XElement.Load(stream).Descendants(Prism + "doi").Select(d => d.Value));
                }
            }

            return dois;
        }

        // Articles must be retrieved individually to get the keywords. A listing of multiple articles includes keywords from all articles therein.
        private void FillArticle(Article article, string url)
        {
            using (var stream = WebRequest.Create(url).GetResponse().GetResponseStream())
            {
                var element = XElement.Load(stream);
                var message = element.Descendants(Pam + "message").Single();
                
                article.Title = message.Descendants(Dc + "title").Single().Value;
                article.Authors = message.Descendants(Dc + "creator").Select(c => c.Value).Distinct().Select(c => new Author { Name = c }).ToEntitySet();
                article.Volume = message.Descendants(Prism + "volume").Single().Value.ToNullableInt();
                article.Issue = message.Descendants(Prism + "number").Single().Value.ToNullableInt();
                article.Page = message.Descendants(Prism + "startingPage").Single().Value.ToNullableInt();
                article.PublishDate = DateTime.Parse(message.Descendants(Prism + "publicationDate").Single().Value);
                article.DOI = message.Descendants(Prism + "doi").Single().Value;
                article.Abstract = string.Join("\n", message.Descendants(Xhtml + "body").Single().Descendants("p").Select(p => p.Value));
                article.Url = message.Descendants(Prism + "url").Single().Value;
                article.Keywords = element.Descendants("facet").Where(f => f.Attribute("name").Value == "keyword").Descendants().Select(k => new Keyword { Name = k.Value }).ToEntitySet();
            }
        }
    }
}