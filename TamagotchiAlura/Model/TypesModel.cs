using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TamagotchiAlura.Model
{
    public class TypesModel
    {
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
        
        [JsonPropertyName("type")]
        public TypeDetails Type { get; set; }
    }

    public class TypeDetails
    {
    [JsonPropertyName("name")]
    public string Name { get; set; }
    }

       
}
