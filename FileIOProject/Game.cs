using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class Game
    {
        public Player Player;
        public List<Room> rooms;
        public Game (Player player)
        {
            this.Player = player;
            this.rooms = new List<Room>();

            Room start = new Room();
            start.player = player;
            player.location = start;
            start.npc.Add(new NPC { Name = "The Chad" });
            //start.player.Add(new Player { Name = Console.ReadLine() }); I want the player to play too no?

            start.description = "Welcome to the thunderdome of file IO! This is the starting room. You see a door to the north and a door to the east.";
            
            this.rooms.Add(start);
            
            Room east = new Room();
             east.description = "You have entered the east room. It is empty except for a door to the south.";
            
             this.rooms.Add(east);

            start.east = east;
            east.west = start;

        }
    }
}
