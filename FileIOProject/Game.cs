using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class Game
    {
        public Player Player;
        public List<Room> rooms;
        public Game(Player player)
        {
            this.Player = player;
            this.Player.Name = player.Name;  // trying to fix error on line 72 "Player.Name" not found
            this.rooms = new List<Room>();

            Room start = new Room();

            Item key = new Item();
            key.types.Add(ItemType.Key);
            key.Name = "a big iron key";
            key.KeyId = 42;

            Item chest = new Item();
            chest.types.Add(ItemType.Lockable);
            chest.Name = "a small wooden chest";
            chest.KeyId = 42;

            player.inventory.Add(key);
            player.inventory.Add(chest);

            start.player = player;
            player.location = start;
            start.npc.Add(new NPC { Name = "The Chad" });
            start.npc.Add(new NPC { Name = "Princess Pumpernickle" });
            start.npc.Add(new Character());
            //start.player.Add(new Player { Name = Console.ReadLine() }); I want the player to play too no?

            start.description = "Welcome to the starting room. You see a door to the north and a door to the east.";

            this.rooms.Add(start);

            Room east = new Room();
            east.description = "You have entered the east room. It is empty except for a door to the south.";

            this.rooms.Add(east);

            start.east = east;
            east.west = start;

        }
        public void save()
        {
            if (this.Player.Name is null)
            {
                throw new Exception("Pick a name bruh, gotta call you something!");
            }
            
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = path + "\\FileIOFun";
            Console.WriteLine(path);
            Console.WriteLine(Directory.Exists(path));

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Creating directory...");
                Directory.CreateDirectory(path);
            }

            path = path + "\\" + this.Player.Name;
                if (!Directory.Exists(path))
            {
                 Console.WriteLine("Creating new path for " + this.Player.Name + ". Welcome to the THUNDERDOME!!");
                 Directory.CreateDirectory(path);
            }
        }
    }
}
