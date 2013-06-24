using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunBoardTracker.Jira.Converters;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class Sprint
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }

        [JsonProperty(PropertyName = "startDate")]
        [JsonConverter(typeof(JiraDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        [JsonConverter(typeof(JiraDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "completeDate")]
        [JsonConverter(typeof(JiraDateTimeConverter))]
        public DateTime? CompleteDate { get; set; }
    }

    public class SprintRoot
    {
        [JsonProperty(PropertyName = "sprints")]
        public List<Sprint> Sprints { get; set; }

        [JsonProperty(PropertyName = "rapidViewId")]
        public int RapidViewId { get; set; }
    }
}
