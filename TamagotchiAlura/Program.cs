
using RestSharp;
using System.Text.Json;
using TamagotchiAlura.Controller;
using TamagotchiAlura.Model;
using TamagotchiAlura.View;

var choosePokemon = new List<string>() { "bulbasaur", "charmander", "squirtle", "pikachu", "eevee" };
var AsciiArt = new List<string>() { "", "", "", "", "" };

//var pokemon = PokemonService.GetPokemon(choosePokemon[3]);
//var pokeText = PokemonService.GetFlavorText(choosePokemon[3]);

Menu.MainMenu();
//PokeInfo.PrintPokeInfo(pokemon, pokeText);

//https://www.asciiart.eu/video-games/pokemon

