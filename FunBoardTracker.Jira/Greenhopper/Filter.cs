using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class Filter
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public Owner Owner { get; set; }

        [JsonProperty(PropertyName = "canEdit")]
        public bool CanEdit { get; set; }

        [JsonProperty(PropertyName = "isOrderedByRank")]
        public bool IsOrderedByRank { get; set; }

        [JsonProperty(PropertyName = "permissionEntries")]
        public List<PermissionEntry> PermissionEntries { get; set; }
    }
}
