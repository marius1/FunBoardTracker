using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Search
{
    public class Issue
    {
        [JsonProperty(PropertyName = "expand")]
        public string Expand { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "self")]
        public string Self { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
}
