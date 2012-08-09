using System.Collections.Generic;
using System.Linq;

namespace JamsParser
{
    public abstract class Query
    {
        protected IDictionary<string, string> Parameters;

        protected Query()
        {
            Parameters = new Dictionary<string, string>
            {
                { "journal", "\"Journal of the Academy of Marketing Science\"" },
                { "sort", "date" }
            };
        }

        public string Build()
        {
            return string.Join(" ", Parameters.Select(p => p.Key + ":" + p.Value));
        }
    }
}