using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class NPC : FSM.StateMachine
    {
        public string Name; //= "The Chad";
        public string Description;  //= "a cool NPC, not like all those other NPCs!";
        // do I need to add more npc's here or should I build a characters class for characters in rooms... yeah that one probably lol
 
       public int Health;

        public NPC() : base(FSM.State.idle)
        {
            //Name = "Princess Pumpernickle";
            //Description = "She loves a good German bread!";
            //Health = 100;
        }
    }
}

