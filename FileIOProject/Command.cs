using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
   
    public class Command
    {
        public void showInventory(Game game)
        {
            Console.WriteLine("The Chad says, Woah! Check out your sick inventory bruh:");
            foreach (var item in game.Player.inventory)
            {
                Console.WriteLine($"- {item.Name}: {item.Description}");
            }
        }
        public void showStats(Game game)
        {
            Console.WriteLine("The Chad says, Here's your stats, bro:");
            Console.WriteLine($"Health: {game.Player.Health}");
            Console.WriteLine($"Location: {game.Player.location.description}");
        }
        public void attack(Game game, List<Token> tokens) // did attack instead of pet and character instead of dog
        {
            var subject = tokens[1];
            Console.WriteLine($"The Chad says, You can't attack {subject} right now, but maybe in the future you'll be able to!");
        }
        public void die(Game game, List<Token> tokens)
                    {
            Console.WriteLine("The Chad says, Oh no! You died! Better luck next time.");
            game.Player.transition(FSM.State.dead);
            game.Player.Health = 0;
            Console.WriteLine($"Your health is now {game.Player.Health}.");
        }
        public void help(Game game, List<Token> tokens)
        {
            Console.WriteLine("The Chad says, Here's what's up bruh:");
            Console.WriteLine("- show inventory: Displays all your SICK inventory.");
            Console.WriteLine("- die: Simulates the player dying and sets health to 0.");
            Console.WriteLine("- help: Shows this help message.");
        }
        public void sleep(Game game, List<Token> tokens)
        {
            Console.WriteLine("The Chad says, Take a nap, you cranky boo! Zzz...");
            game.Player.Sleep();
        }
        public void look(Game game, List<Token> tokens)
        {
            var room = game.Player.location;
            Console.WriteLine("The Chad says, Look around dude, take it all in...");
            Console.WriteLine(room.description);
            Console.WriteLine();

            foreach(var npc in room.npc) // my thought was to use var character but idk now
            {
                Console.WriteLine($"You see {npc.Description} here.");
            }
            if (room.north is not null)
            {
                Console.WriteLine("To the north, you see " + room.north.description);
            }
            if (room.east is not null)
            {
                Console.WriteLine("To the east, you see " + room.east.description);
            }
            if (room.south is not null)
            {
                Console.WriteLine("To the south, you see " + room.south.description);
            }
            if (room.west is not null)
            {
                Console.WriteLine("To the west, you see " + room.west.description);
            }
        }
        public void move(Game game, List<Token> tokens)
        {
            var direction = tokens[1];
            if(direction is not null)
            {
                if(direction.Value == "north" && game.Player.location.north is not null)
                {
                    game.Player.location = game.Player.location.north;
                    Console.WriteLine("You moved north my dude.");
                } else if(direction.Value == "east" && game.Player.location.east is not null)
                {
                    game.Player.location = game.Player.location.east;
                    Console.WriteLine("You moved east my dude.");
                } else if(direction.Value == "south" && game.Player.location.south is not null)
                {
                    game.Player.location = game.Player.location.south;
                    Console.WriteLine("You moved south my dude.");
                } else if(direction.Value == "west" && game.Player.location.west is not null)
                {
                    game.Player.location = game.Player.location.west;
                    Console.WriteLine("You moved west my dude.");
                } else
                {
                    Console.WriteLine("You can't go that way my dude.");
                    return;
                }
                Console.WriteLine("You moved to the " + direction.Value + ".");
                this.look(game, tokens);
            }else
            {
                Console.WriteLine("Pick a direction, homie! It ain't life or death or nothin... it's just a game dude. Chill.");
            }
        }
        public void useKey(Game game, List<Token> tokens)
        {
            var Key = tokens[1];
            var Lockable = tokens[2];
            var inv = game.Player.inventory;

            var keyQuery = inv.Where<Item>((i) => i.types.Contains(ItemType.Key) && i.Name.Contains(Key.Value)).First();

            var lockableQuery = inv.Where<Item>((i) => i.types.Contains(ItemType.Lockable) && i.Name.Contains(Key.Value)).First();

            if (keyQuery is not null)
            {
                //do stuff
            }
        }
        public void quit(Game game, List<Token> tokens)
        {
            Console.WriteLine("Peace out GirlScout! Ta-ta for now...");
            Environment.Exit(0);
        }
    }
}
