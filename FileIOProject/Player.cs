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
        public List<Item> inventory = new List<Item>();


        public Player() : base(FSM.State.idle)
        {
            this.Name = "{playerName}";
            this.Health = 100;
        }
        public void Sleep()
        {
            this.transition(FSM.State.sleeping);
            Console.WriteLine($"{this.Name} is sleeping.");
        }
    }
}
