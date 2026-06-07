using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class Room
    {
        public List<NPC> npc = new List<NPC>();
        public Player? player;
        public string description;
        public Room? north;
        public Room? south;
        public Room? east;
        public Room? west;

        // items, treasure, traps...
        public List<Item> items = new List<Item>(); 
        public List<Trap> traps = new List<Trap>();
        public List<Treasure> treasures = new List<Treasure>();
    }
}
