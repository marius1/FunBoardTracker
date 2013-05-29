using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class StatFieldValue
    {
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }
    }
}
