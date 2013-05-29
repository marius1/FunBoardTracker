using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class EstimateSum
    {
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
