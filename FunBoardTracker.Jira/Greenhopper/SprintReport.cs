using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class SprintReport
    {
        [JsonProperty(PropertyName = "contents")]
        public Contents Contents { get; set; }

        [JsonProperty(PropertyName = "sprint")]
        public Sprint Sprint { get; set; }
    }
    
    public class Contents
    {
        [JsonProperty(PropertyName = "completedIssues")]
        public List<Issue> CompletedIssues { get; set; }

        [JsonProperty(PropertyName = "incompletedIssues")]
        public List<Issue> IncompletedIssues { get; set; }

        [JsonProperty(PropertyName = "puntedIssues")]
        public List<object> PuntedIssues { get; set; }

        [JsonProperty(PropertyName = "completedIssuesEstimateSum")]
        public EstimateSum CompletedIssuesEstimateSum { get; set; }

        [JsonProperty(PropertyName = "incompletedIssuesEstimateSum")]
        public EstimateSum IncompletedIssuesEstimateSum { get; set; }

        [JsonProperty(PropertyName = "allIssuesEstimateSum")]
        public EstimateSum AllIssuesEstimateSum { get; set; }

        [JsonProperty(PropertyName = "puntedIssuesEstimateSum")]
        public EstimateSum PuntedIssuesEstimateSum { get; set; }

        /*[JsonProperty(PropertyName = "issueKeysAddedDuringSprint")]
        public IssueKeysAddedDuringSprint issueKeysAddedDuringSprint { get; set; }*/
    }
}
