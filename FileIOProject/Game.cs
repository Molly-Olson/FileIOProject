using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class Game
    {
        public Player Player { get; set; }
        public List<Room> rooms { get; set; }
        public Game()
        {

        }
        public Game(Player player)
        {
            this.Player = player;
           // this.Player.Name = player.Name;  // trying to fix error on line 72 "Player.Name" not found
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

            Item sword = new Item();
            sword.types.Add(ItemType.Weapon);
            sword.Name = "old rusty sword";
            sword.Description = "This rusty old sword is still sharp, dude!";
            
            Item potion = new Item();
            potion.types.Add(ItemType.Consumable);
            potion.Name = "magic healing potion";
            potion.Description = "This potion will heal you up, bro! Chug it! Chug it! Chug it!";

            Item knightSuit = new Item();
            knightSuit.types.Add(ItemType.Armor);
            knightSuit.Name = "a suit of knight's armor";
            knightSuit.Description = "Woah check out this sweet armor! You gunna wear it my G? Cause I totally will if you don't want to!";

            Item trap = new Item();
            trap.types.Add(ItemType.Trap);
            trap.Name = "a spiked pit trap";
            trap.Description = "Watch your step, bro! You might fall into this spiked pit trap and lose some health!";

            Item cake = new Item();
            cake.types.Add(ItemType.Consumable);
            cake.Name = "a slice of cake";
            cake.Description = "Let them eat cake!";

            player.inventory.Add(key);
            player.inventory.Add(chest);

            start.player = player;
            player.location = start;
            //start.npc.Add(new NPC { Name = "The Chad" });
            //start.npc.Add(new NPC { Name = "Princess Pumpernickle" });
            //start.npc.Add(new Character());
            //start.player.Add(new Player { Name = Console.ReadLine() }); I want the player to play too no?

            _ = new Room();
            start.description = "Starting room. You see a door to the north and a door to the east.";

            this.rooms.Add(start);

            Room east = new Room();
            east.description = "East room. It is empty except for a door to the south.";
            this.rooms.Add(east);

            start.east = east;
            east.west = start;

            Room eastAgain = new Room();
            eastAgain.description = "Well, like now you're just going in circles silly!";  // ok I am gettin so frustrated! I can't figure out these stupid messages
            this.rooms.Add(eastAgain);

            east.east = eastAgain;
            eastAgain.west = east;
             
            Room north = new Room();
            north.description = "North room. Check out the door to the south.";
            this.rooms.Add(north);

            Room south = new Room();
            south.description = "South room. It's pretty empty, but you can see a door to the north.";
            this.rooms.Add(south);

            Room northEast = new Room();
            northEast.description = "Northeast room. It's pretty empty, but you can see a door to the south.";
            this.rooms.Add(northEast);

            Room west = new Room();
            west.description = "West room. It's pretty empty, but you can see a door to the east.";
            this.rooms.Add(west);

            Room tower = new Room();
            tower.description = "Tower room. It's pretty empty, but you can see a door to the south.";
            this.rooms.Add(tower);

            start.north = north;
            north.south = start;
            east.north = north;
            north.south = east;
            west.north = northEast;
            northEast.south = west;
            tower.south = northEast;

            north.items.Add(sword);
            east.items.Add(potion);
            northEast.items.Add(knightSuit);
            west.items.Add(trap);
            tower.items.Add(cake);


        }
        public Game load()
        {
            if (Player.Name is null)
            {
                throw new Exception("Pick a name, yo mama gave you one. Use that!");
            }

            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = Path.Combine(path, "FileIOFun");
            path = Path.Combine(path, Player.Name);
            path = Path.Combine(path, "save.json");
            //Console.WriteLine(path);
            //Console.WriteLine(Directory.Exists(path));

            if (!File.Exists(path))
            {
                throw new PlayerNotFoundException("That's not a player dude.");
            }

            string jsondata;

            using (StreamReader sr = new StreamReader(path))
            {
                jsondata = sr.ReadToEnd();
            }

            //Console.WriteLine(jsondata);

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true,
                IncludeFields = true
            };

            Game? game = JsonSerializer.Deserialize<Game>(jsondata, options);

            if (game is null)
            {
                throw new Exception("Womp womp womp... FAILURE!");
            }
            else
            {
                return game;
            }
        }
            

        public void save()
        {
            // Console.WriteLine("this.Player.Name");
            if (Player.Name is null)
            {
                throw new Exception("Pick a name, yo mama gave you one. Use that!");
            }

            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = Path.Combine(path, "FileIOFun"); 

        // Im confused and like why is my game and Player not showing 

            if (!Directory.Exists(path))  // is this different? I confused
            {
               // Console.WriteLine("Creating directory...");
                Directory.CreateDirectory(path);
            }

            path = Path.Combine(path, this.Player.Name);
                if (!Directory.Exists(path))
                {
                 //Console.WriteLine("Creating new path for " + this.Player.Name + ". Welcome to the THUNDERDOME!!");
                 Directory.CreateDirectory(path);
                }
            Console.WriteLine(path);

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true,
                IncludeFields = true
            };

            var jsondata = JsonSerializer.Serialize(this, options);
            using (StreamWriter sw = new StreamWriter(Path.Combine(path, "save.json")))
            {
                sw.Write(jsondata);
            }

        }
    }
}
