using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class Player : FSM.StateMachine
    {
        public string Name;
        public int Health;
        public Room location;
        

        public Player() : base(FSM.State.idle)
        {
        }
        public Player(string Name, int Health) : base(FSM.State.idle)
        {
            this.Name = Name;
            this.Health = Health;
        }
    }
}
