using Newtonsoft.Json;
using System;

namespace Diplomatic.Core
{
    [Serializable]
    public class Field
    {
        [JsonProperty("name")]
        public string Name { get; }
        [JsonIgnore]
        public string Value { get; set; }

        public Field(string name)
        {
            Name = name;
            Value = "";
        }
    }
}
