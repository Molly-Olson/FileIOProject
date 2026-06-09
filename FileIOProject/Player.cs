using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public class Player : FSM.StateMachine
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Room location { get; set; }
        public List<Item> inventory { get; set; } = new List<Item>();


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
