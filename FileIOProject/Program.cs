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
            string path = @"C:\Temp\PlayerData.txt";

            Console.WriteLine("Let's do some JSON file IO saving shall we?");
            Console.WriteLine("Maybe...");
            Console.WriteLine();
            Console.WriteLine(" ----------------------------------------------------- ");
            Console.WriteLine("Enter Player Name.");
            Console.WriteLine(" ----------------------------------------------------- ");
            Console.WriteLine();

            string playerName = Console.ReadLine();

            Player player = new Player { Name = playerName };
            Game game = new Game(player);

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
