
using RestSharp;
using System.Text.Json;
using TamagotchiAlura.Controller;
using TamagotchiAlura.Model;
using TamagotchiAlura.View;

var choosePokemon = new List<string>() { "bulbasaur", "charmander", "squirtle", "pikachu", "eevee" };
var pokemon = PokemonService.GetPokemon(choosePokemon[3]);
//var flavorText = PokemonService.GetFlavorText();
var pokeText = PokemonService.GetFlavorText(choosePokemon[0]);

PokeInfo.PrintPokeInfo(pokemon, pokeText);
//Console.WriteLine(texto.FlavorText[0].Text);





