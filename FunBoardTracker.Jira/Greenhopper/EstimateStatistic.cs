using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class EstimateStatistic
    {
        [JsonProperty(PropertyName = "statFieldId")]
        public string StatFieldId { get; set; }

        [JsonProperty(PropertyName = "statFieldValue")]
        public StatFieldValue StatFieldValue { get; set; }
    }
}
