namespace JamsParser
{
    public class VolumeIssueQuery : Query
    {
        public VolumeIssueQuery(int? volume, int? issue)
        {
            if (volume != null) Parameters.Add("volume", volume.ToString());
            if (issue != null) Parameters.Add("issue", issue.ToString());
        }
    }
}