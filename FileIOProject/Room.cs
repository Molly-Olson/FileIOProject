using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class Room
    {
        public string Name;
        public string description;
        public List<NPC> npc = new List<NPC>();
        public Player? player;
        public Room? north;
        public Room? south;
        public Room? east;
        public Room? west;

        // items, treasure, traps...
       // public List<Item> items = new List<Item>();  // not quite ready for this but I know this is where I am headed
    }
}
