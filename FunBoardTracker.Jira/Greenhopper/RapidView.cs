using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class RapidViewRoot
    {
        [JsonProperty(PropertyName = "views")]
        public List<RapidView> Views { get; set; }
    }
    
    public class RapidView
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "canEdit")]
        public bool CanEdit { get; set; }

        [JsonProperty(PropertyName = "sprintSupportEnabled")]
        public bool SprintSupportEnabled { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public Owner Owner { get; set; }

        [JsonProperty(PropertyName = "filter")]
        public Filter Filter { get; set; }
    }
}
