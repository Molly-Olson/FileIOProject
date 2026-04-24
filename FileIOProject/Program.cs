using System;
using System.IO;
using System.Text.Json;

namespace FileIOProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\PlayerData.json";

            Console.WriteLine("Let's do some JSON file IO saving shall we?");
            Console.WriteLine("Maybe...");
            Console.WriteLine();
            Console.WriteLine(" ----------------------------------------------------- ");
            Console.WriteLine("Enter Player Name.");
            Console.WriteLine(" ----------------------------------------------------- ");
            Console.WriteLine();

            string playerName = Console.ReadLine();

            Player player = new Player { Name = playerName };
            Game game = new Game { Player = player };

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    // I am so lost
                }
            }
            
        }
    }
}
