using System;
using System.IO;
using System.Text.Json;
using FileIOProject;

namespace FileIOProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            string path = @"C:\Temp\PlayerData.txt";

            Console.WriteLine("Let's do some JSON file IO saving shall we?");
            Console.WriteLine("Maybe...");
            Console.WriteLine();
            Console.WriteLine(" ----------------------------------------------------- ");
            Console.WriteLine("What is your name oh fine adventurer?");
            Console.WriteLine(" ----------------------------------------------------- ");
            Console.WriteLine();
            
            string playerName = Console.ReadLine();

            Player player = new Player { Name = playerName };
            Game game = new Game(player);
            NPC nPC = new NPC { Name = "The Chad" };

            Console.WriteLine(" ----------------------------------------------------- ");
            Console.WriteLine("Hello, " + playerName + "!");
            Console.WriteLine(" ----------------------------------------------------- ");


            if (File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    string jsonData = JsonSerializer.Serialize(player);
                    writer.WriteLine(jsonData);
                }
            }
            using StreamReader reader = File.OpenText(path);
            {
                string s;
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine(" ----------------------------------------------------- ");
                Console.WriteLine("Would you like to meet your opponent? (Y/N)");
                Console.WriteLine(" ----------------------------------------------------- ");
                string response = Console.ReadLine();
                if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Say Hello to {nPC.Name}!");
                    Console.WriteLine(" ----------------------------------------------------- ");
                    Console.WriteLine($"{nPC.Name} wants to know if you want to play a game with him? (Y/N)");
                    Console.WriteLine(" ----------------------------------------------------- ");
                    string response2 = Console.ReadLine();
                    if (response2.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("He said he wants to play a game with you!");
                    }
                    else                    {
                        Console.WriteLine("He said he didn't want to play a game with you either, toots.");
                    }
                }
                else
                {
                    Console.WriteLine("He said he didn't want to meet you either.");
                }
                LookupTable lookupTable = new LookupTable();

                while (loop)
                {
                    Console.WriteLine(" ----------------------------------------------------- ");
                    Console.WriteLine("Whatdya wanna like do my dude?");
                    Console.WriteLine(" ----------------------------------------------------- ");
                    var input = Console.ReadLine();

                    Tokenizer t = new Tokenizer();
                    var ast = t.Tokenize(input);

                    var verb = ast.Where(x => x.Name == TokenType.verb).FirstOrDefault();
                    if (verb is not null)
                    {
                        try
                        {
                            Action action = lookupTable[verb.Value];
                            action(game, ast);
                        }
                        catch (KeyNotFoundException e)
                        {
                            Console.WriteLine("Bruh IDK how to do that, try again.");
                        }
                    } else
                    {
                        Console.WriteLine("I have no idea what you just said, bad verb dude.");
                    }
                }
            }
        }
    }
}

//string path = @"C:\Temp\PlayerData.txt";

//// ... (console input code remains the same)

//Player player = new Player { Name = playerName };
//Game game = new Game(player);

//// Write player data to file (always, or only if you want to overwrite)
//using (StreamWriter writer = File.CreateText(path))
//{
//    string jsonData = JsonSerializer.Serialize(player);
//    writer.WriteLine(jsonData);
//}

//// Read and display the file contents
//using (StreamReader reader = File.OpenText(path))
//{
//    string s;
//    while ((s = reader.ReadLine()) != null)
//    {
//        Console.WriteLine(s);
//    }
//}
