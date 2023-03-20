using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiAlura.Controller;

namespace TamagotchiAlura.View
{
    public static class Menu
    {

        public static void MainMenu()
        {
            Console.WriteLine("              _                              \r\n  _ __   ___ | | _____ _ __ ___   ___  _ __  \r\n | '_ \\ / _ \\| |/ / _ \\ '_ ` _ \\ / _ \\| '_ \\ \r\n | |_) | (_) |   <  __/ | | | | | (_) | | | |\r\n | .__/ \\___/|_|\\_\\___|_| |_| |_|\\___/|_| |_|\r\n |_|                                         \n\n");

            Console.WriteLine("Hello PokeMaster! What's your name? "); //ARRUMAR ISSO AQUI
            var playerName = Console.ReadLine();

            Console.WriteLine("Welcome to your journey to become the greatest of all time!");
            Console.WriteLine($"{playerName}, choose an option");
            Console.WriteLine("1 - See your mascot");
            Console.WriteLine("2 - Choose a mascot");
            Console.WriteLine("3 - Exit");
            
            var choice = Validate(3, 1);
            switch (choice)
            {
                case 1:
                    YourPokemons();
                    break;
                case 2:
                    ChoiceMenu();
                    break;
                case 3:
                    Console.WriteLine("See you!");
                    Environment.Exit(0);
                    break;
            }
           
        }

        public static void ChoiceMenu()
        {
            Console.Clear();
            var choosePokemon = new List<string>() { "bulbasaur", "charmander", "squirtle", "pikachu", "eevee" };

            Console.WriteLine("Which Pokemon would you like to know more?");
            int number = 1;
            foreach(var pokeName in choosePokemon)
            {
                Console.WriteLine($"{number} - {PokeInfo.Capitalize(pokeName)}");
                number++;
            }
            Console.WriteLine("6 - Return");
            var choice = Validate(6, 1);
            Console.Clear();
            switch (choice)
            {
                case 1:
                    PokemonService.CallPokemon(choosePokemon[0]);
                    //Console.WriteLine("                                           /\r\n                        _,.------....___,.' ',.-.\r\n                     ,-'          _,.--\"        |\r\n                   ,'         _.-'              .\r\n                  /   ,     ,'                   `\r\n                 .   /     /                     ``.\r\n                 |  |     .                       \\.\\\r\n       ____      |___._.  |       __               \\ `.\r\n     .'    `---\"\"       ``\"-.--\"'`  \\               .  \\\r\n    .  ,            __               `              |   .\r\n    `,'         ,-\"'  .               \\             |    L\r\n   ,'          '    _.'                -._          /    |\r\n  ,`-.    ,\".   `--'                      >.      ,'     |\r\n . .'\\'   `-'       __    ,  ,-.         /  `.__.-      ,'\r\n ||:, .           ,'  ;  /  / \\ `        `.    .      .'/\r\n j|:D  \\          `--'  ' ,'_  . .         `.__, \\   , /\r\n/ L:_  |                 .  \"' :_;                `.'.'\r\n.    \"\"'                  \"\"\"\"\"'                    V\r\n `.                                 .    `.   _,..  `\r\n   `,_   .    .                _,-'/    .. `,'   __  `\r\n    ) \\`._        ___....----\"'  ,'   .'  \\ |   '  \\  .\r\n   /   `. \"`-.--\"'         _,' ,'     `---' |    `./  |\r\n  .   _  `\"\"'--.._____..--\"   ,             '         |\r\n  | .\" `. `-.                /-.           /          ,\r\n  | `._.'    `,_            ;  /         ,'          .\r\n .'          /| `-.        . ,'         ,           ,\r\n '-.__ __ _,','    '`-..___;-...__   ,.'\\ ____.___.'\r\n `\"^--'..'   '-`-^-'\"--    `-^-'`.''\"\"\"\"\"`.,^.`.--' mh");
                    ReturnToChoiceMenu(choosePokemon[0]);
                    break;
                case 2:
                    PokemonService.CallPokemon(choosePokemon[1]);
                    //Console.WriteLine("              _.--\"\"`-..\r\n            ,'          `.\r\n          ,'          __  `.\r\n         /|          \" __   \\\r\n        , |           / |.   .\r\n        |,'          !_.'|   |\r\n      ,'             '   |   |\r\n     /              |`--'|   |\r\n    |                `---'   |\r\n     .   ,                   |                       ,\".\r\n      ._     '           _'  |                    , ' \\ `\r\n  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\r\n  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\r\n-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\r\n  `,         \"\"\"\"'     `.              ,'         |   |  ',,\r\n    `.      '            '            /          '    |'. |/\r\n      `.   |              \\       _,-'           |       ''\r\n        `._'               \\   '\"\\                .      |\r\n           |                '     \\                `._  ,'\r\n           |                 '     \\                 .'|\r\n           |                 .      \\                | |\r\n           |                 |       L              ,' |\r\n           `                 |       |             /   '\r\n            \\                |       |           ,'   /\r\n          ,' \\               |  _.._ ,-..___,..-'    ,'\r\n         /     .             .      `!             ,j'\r\n        /       `.          /        .           .'/\r\n       .          `.       /         |        _.'.'\r\n        `.          7`'---'          |------\"'_.'\r\n       _,.`,_     _'                ,''-----\"'\r\n   _,-_    '       `.     .'      ,\\\r\n   -\" /`.         _,'     | _  _  _.|\r\n    \"\"--'---\"\"\"\"\"'        `' '! |! /\r\n                            `\" \" -' mh");
                    ReturnToChoiceMenu(choosePokemon[1]);
                    break;
                case 3:
                    PokemonService.CallPokemon(choosePokemon[2]);
                    //Console.WriteLine("               _,........__\r\n            ,-'            \"`-.\r\n          ,'                   `-.\r\n        ,'                        \\\r\n      ,'                           .\r\n      .'\\               ,\"\".       `\r\n     ._.'|             / |  `       \\\r\n     |   |            `-.'  ||       `.\r\n     |   |            '-._,'||       | \\\r\n     .`.,'             `..,'.'       , |`-.\r\n     l                       .'`.  _/  |   `.\r\n     `-.._'-   ,          _ _'   -\" \\  .     `\r\n`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\r\n.'        `\"-..___      __,'\\          \\  \\     \\\r\n\\_ .          |   `\"\"\"\"'    `.           . \\     \\\r\n  `.          |              `.          |  .     L\r\n    `.        |`--...________.'.        j   |     |\r\n      `._    .'      |          `.     .|   ,     |\r\n         `--,\\       .            `7\"\"' |  ,      |\r\n            ` `      `            /     |  |      |    _,-'\"\"\"`-.\r\n             \\ `.     .          /      |  '      |  ,'          `.\r\n              \\  v.__  .        '       .   \\    /| /              \\\r\n               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\r\n                `        .        `._ ___,j.  `/ .-       ,---.     |\r\n                ,`-.      \\         .\"     `.  |/        j     `    |\r\n               /    `.     \\       /         \\ /         |     /    j\r\n              |       `-.   7-.._ .          |\"          '         /\r\n              |          `./_    `|          |            .     _,'\r\n              `.           / `----|          |-............`---'\r\n                \\          \\      |          |\r\n               ,'           )     `.         |\r\n                7____,,..--'      /          |\r\n                                  `---.__,--.'mh");
                    ReturnToChoiceMenu(choosePokemon[2]);
                    break;
                case 4:
                    PokemonService.CallPokemon(choosePokemon[3]);
                    //Console.WriteLine(" :::,\r\n '::::'._\r\n   '.    '.                        __.,,.\r\n     '.    '.                _..-'''':::\"\r\n       \\     \\,.--\"\"\"\"--.,-''      _:'\r\n   /\\   \\  .               .    .-'\r\n  /  \\   \\                   ':'\r\n /    \\  :                     :\r\n/      \\:                       :\r\n\\       :                       :\r\n \\      :      ,--,         ,-,  :\r\n  \\    :      |(_):|       |():| :\r\n   \\   :     __'--'   __    '-'_  :\r\n    \\  :    /  \\      \\/      / \\ :\r\n     \\  :  (    )             \\_/ :\r\n  .-'' . :  \\__/   '--''--'      :\r\n  \\  . .-:'.                   .:\r\n   \\' :| :  '-.__      ___...-' :\r\n    \\::|:        ''''''          '.\r\n  .,:::':  :                       '.\r\n   \\::\\:   :                         '._\r\n    \\::    :     /             '-._     '.\r\n     \\:    :    /              .   :-._ :-'\r\n      :    :   /               :   :  ''\r\n      :   .'   )'.             :   :\r\n sjw   :  :  .'   '.          :   :\r\n        : '..'      :      _.' _.:\r\n         '._        :..---'\\'''  _)\r\n            '':---''_)      '-'-'\r\n               '-'-'  PIKACHU!");
                    ReturnToChoiceMenu(choosePokemon[3]);
                    break;
                case 5:
                    PokemonService.CallPokemon(choosePokemon[4]);
                    //Console.WriteLine("                                      |\r\n                                     /|\r\n                                   ,' |\r\n                                  .   |\r\n                                    | |\r\n                                 ' '| |\r\n                                / / | |\r\n       _,.-\"\"--._              / /  | |\r\n     ,'          `.           j '   ' '\r\n   ,'              `.         ||   / ,                         ___..--,\r\n  /                  \\        ' `.'`.-.,-\".  .       _..---\"\"'' __, ,'\r\n /                    \\        \\` .\"`      `\"'\\   ,'\"_..--''\"\"\"'.'.'\r\n.                      .      .'-'             \\,' ,'         ,','\r\n|                      |      ,`               ' .`         .' /\r\n|                      |     /          ,\"`.  ' `-. _____.-' .'\r\n'                      |..---.|,\".      | | .  .-'\"\"   __.,-'\r\n .                   ,'       ||,|      |.' |    |\"\"`'\"\r\n  `-._   `._.._____  |        || |      `._,'    |\r\n      `.   .       `\".     ,'\"| \"  `'           ,+.\r\n        \\  '         |    '   |   .....        .'  `.\r\n         .'          '     7  \".              ,'     \\\r\n                   ,'      |    `..        _,'      F\r\n                  .        |,      `'----''         |\r\n                  |      ,\"j  /                   | '\r\n                  `     |  | .                 | `,'\r\n                   .    |  `.|                 |/\r\n                    `-..'   ,'                .'\r\n                            | \\             ,''\r\n                            |  `,'.      _,' /\r\n                            |    | ^.  .'   /\r\n                             `-'.' j` V    /\r\n                                   |      /\r\n                                   |     /\r\n                                   |   ,'\r\n                                    `\"\"");
                    ReturnToChoiceMenu(choosePokemon[4]);
                    break;
                case 6:
                    MainMenu();
                    break;
            }
        }

        public static int Validate(int max, int min)
        {
            var check = true;
            int choice;

            check = int.TryParse(Console.ReadLine(), out choice);
            while (check is not true || choice > max || choice < min)
            {
                Console.WriteLine("Oops! Choose a valid option");
                check = int.TryParse(Console.ReadLine(), out choice);
            }
            return choice;
        }

        public static void ReturnToChoiceMenu(string pokeName) //RENOMEAR ESSE METODO
        {
            Console.WriteLine("Do you want to choose this pokemon?");
            Console.WriteLine("1 - Yes \n2 - No");
            var choice = Validate(2, 1);
            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine($"You choose {pokeName}");
                Console.WriteLine("Press any key to go see your Pokemons!");
                Console.ReadLine();
                YourPokemons();
            }
            else { ChoiceMenu(); }
             
        }

        public static void YourPokemons()
        {
            Console.WriteLine("aqui vai ver os pokemão");
        }
        
    }
}
