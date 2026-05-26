using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class NPC : FSM.StateMachine
    {
        public string Name = "The Chad"; 
 
        public int Health { get; set; } = 100;

        public NPC() : base(FSM.State.idle)
        {
        }
    }
}
