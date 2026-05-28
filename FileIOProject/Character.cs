using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    internal class Character : NPC
    {
        internal Character()
        {
            Name = "Princess Pumpernickle";
            Description = "She loves a good German bread!";
            Health = 100;
        }

        // do I have to make a seperate class for each npc character I want? like this character inherits from npc so if I want a toad he needs his own too right or can't i just have 
        // a bunch of characters here? ugh


        //internal Character()
        //{
        //    Name = "The Chad";
        //    Description = "He's a cool NPC, not like all those other NPC's.";
        //    Health = 100;
        //}
    
        
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public int Health { get; set; }

        //public Character(string name, string description, int health)
        //{
        //    Name = name;
        //    Description = description;
        //    Health = health;
        //}
        //public Character()
        //{
        //    Name = "Princess Pumpernickle";
        //    Description = "She loves a good German bread!";
        //    Health = 100;
        //}
    }
}
// wait, maybe I don't want this class??? arg lol