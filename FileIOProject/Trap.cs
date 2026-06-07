using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public enum TrapType
    {
        Pitfall,
        Spike,
        Poison,
        Fire,
        Magic
    }
    internal class Trap
    {
        public string Name;
        public string Description;
        public int TrapId;

        public List<TrapType> types = new List<TrapType>();
        public void activate(Trap TrapObject)
        {
            if (this.types.Contains(TrapType.Pitfall))
            {
                Console.WriteLine("Oh No! The pit of despair!!! Goodbye!");
                // where code to kill this dude go?
            }
            if (this.types.Contains(TrapType.Spike))
            {
                Console.WriteLine("Yikes! Spikes! Hope you have your ARMOR my dude.");
                // if they have armor vs not need a way to handle damage 
            }
            if (this.types.Contains(TrapType.Poison))
            {
                Console.WriteLine("Bruh, did you just drink that?!");
                // I wanna have them lose healt and disiplay that
            }
            if (this.types.Contains(TrapType.Fire))
            {
                Console.WriteLine("Are we in your ex's house? Cause I feel burned!");
                // where and how to show damage by fire
            }
            if (this.types.Contains(TrapType.Magic))
            {
                Console.WriteLine("OOOH Gurl, it was getting hairy! You needed some magic!");
                // restore full health 
            }
            else
            {
                Console.WriteLine("You must be lucky! Go buy a ticket and give me my cut...");
            }
        }
    }
}
