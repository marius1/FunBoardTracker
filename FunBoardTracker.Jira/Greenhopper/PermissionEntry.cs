using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class PermissionEntry
    {
        [JsonProperty(PropertyName = "values")]
        public List<Value> Values { get; set; }
    }
}
