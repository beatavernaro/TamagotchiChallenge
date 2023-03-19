using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TamagotchiAlura.Model;

namespace TamagotchiAlura.Controller
{
    public static class PokemonService
    {
        public static PokemonModel GetPokemon(string pokeName)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokeName}");
            var request = new RestRequest("",Method.Get);
            var response = client.Execute(request);
            return JsonSerializer.Deserialize<PokemonModel>(response.Content);
        }

        public static FlavorTextModel GetFlavorText(string pokeName)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon-species/{pokeName}");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);
            return JsonSerializer.Deserialize<FlavorTextModel>(response.Content);
        }
    }
}
