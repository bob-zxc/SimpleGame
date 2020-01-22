using System;
using SimpleGame.Domain.Factory;
using SimpleGame.Domain.Model;

namespace Cli
{
    class Program
    {
        static void Main(string[] args)
        {

            var playerId = new PlayerId("DavidCreixell");
            var houseFactory = new HouseFactory();
            var house = houseFactory.CreateInitialHouse();
            var game = new Game(playerId, house);

            while (true)
            {
                Console.WriteLine("------------------------------------");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Your house now:");
                Console.WriteLine($" - Level: {game.House.Level}");
                Console.WriteLine($" - Color: {game.House.Color}");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("> paint <color> (1 Blue or paint blue)");
                Console.WriteLine("> level-up (2 or level-up)");
                Console.WriteLine("> q (Quit)");
                Console.WriteLine("");
                
                var inputValue = Console.ReadLine();
                if (inputValue == null) continue;
                
                var splittedString = inputValue.Split(new char[0]);

                switch (splittedString[0])
                {
                    case "q":
                        Console.WriteLine("GAME OVER");
                        return;
                    case "paint":
                    case "1":
                        if (splittedString.Length != 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong format, please use a valid one.");
                            Console.ResetColor();
                            break;
                        }
                        game.House.Paint(splittedString[1]);
                        break;
                    case "level-up":
                    case "2":
                        game.House.LevelUp();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Invalid command {splittedString[0]}");
                        Console.ResetColor();
                        break;
                }
                
                Console.WriteLine("------------------------------------");
            }

        }
    }
}