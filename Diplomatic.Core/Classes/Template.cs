using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Diplomatic.Core
{
    [Serializable]
    public class Template
    {
        [JsonProperty("name")]
        public string TemplateName { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("fields")]
        public IEnumerable<Field> Fields { get; set; }

        public Template(string name, string path, IEnumerable<Field> fields)
        {
            TemplateName = name;
            Path = path;
            Fields = fields;
        }
    }
}
