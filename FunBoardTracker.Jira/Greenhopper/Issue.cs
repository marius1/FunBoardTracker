using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira.Greenhopper
{
    public class Issue
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "hidden")]
        public bool Hidden { get; set; }

        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        [JsonProperty(PropertyName = "typeId")]
        public string TypeId { get; set; }

        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        [JsonProperty(PropertyName = "typeUrl")]
        public string TypeUrl { get; set; }

        [JsonProperty(PropertyName = "priorityUrl")]
        public string PriorityUrl { get; set; }

        [JsonProperty(PropertyName = "priorityName")]
        public string PriorityName { get; set; }

        [JsonProperty(PropertyName = "done")]
        public bool Done { get; set; }

        [JsonProperty(PropertyName = "assignee")]
        public string Assignee { get; set; }

        [JsonProperty(PropertyName = "assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty(PropertyName = "avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "estimateStatistic")]
        public EstimateStatistic EstimateStatistic { get; set; }

        [JsonProperty(PropertyName = "statusId")]
        public int StatusId { get; set; }

        [JsonProperty(PropertyName = "statusName")]
        public string StatusName { get; set; }

        [JsonProperty(PropertyName = "statusUrl")]
        public string StatusUrl { get; set; }

        [JsonProperty(PropertyName = "fixVersions")]
        public List<int> FixVersions { get; set; }

        [JsonProperty(PropertyName = "projectId")]
        public int ProjectId { get; set; }

        [JsonProperty(PropertyName = "epic")]
        public string Epic { get; set; }

        public override string ToString()
        {
            return Key;
        }

        public Status Status { get { return (Status) StatusId; } }
    }
}
