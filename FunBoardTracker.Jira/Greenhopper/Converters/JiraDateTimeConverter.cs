using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FunBoardTracker.Jira.Greenhopper.Converters
{
    public class JiraDateTimeConverter : DateTimeConverterBase
    {
        private const string DATETIME_FORMAT = "dd/MMM/yy h:mm tt";

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
            {
                throw new Exception(String.Format("Unexpected token parsing date. Expected String, got {0}.", reader.TokenType));
            }
            string value = reader.Value.ToString();

            if (value == "None")
                return null;

            return DateTime.ParseExact(reader.Value.ToString(), DATETIME_FORMAT, new CultureInfo("en-US"));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is DateTime?))
                throw new Exception("Expected date object value.");

            DateTime? dateTimeValue = (DateTime?) value;

            string write = dateTimeValue.HasValue ? dateTimeValue.Value.ToString(DATETIME_FORMAT, new CultureInfo("en-US")) : "None";
            writer.WriteValue(write);
        }
    }
}
