using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TamagotchiAlura.Model
{
    public class FlavorTextModel
    {
        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorText> FlavorText { get; set; }
    }

    public class FlavorText
    {
        [JsonPropertyName("flavor_text")]
        public string Text { get; set; }
    }
}
