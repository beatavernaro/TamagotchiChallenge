using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiAlura.Model;

namespace TamagotchiAlura.View
{
    public class PokeInfo
    {
        public static void PrintPokeInfo(PokemonModel model, FlavorTextModel flavor)
        {

            Console.WriteLine($"Name: {Capitalize(model.Name)}");
            foreach (var pokeType in model.Types)
            {
                Console.WriteLine($"Type {pokeType.Slot}: {Capitalize(pokeType.Type.Name)}");
            }
            Console.WriteLine($"Weight: {(decimal)model.Weight/10} kg");
            Console.WriteLine($"Height: {model.Height*10} cm\n");
            Console.WriteLine(flavor.FlavorText[0].Text);
        }


        public static string Capitalize(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }

}
