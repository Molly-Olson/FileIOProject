using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public enum TreasureType
    {
        Gold,
        Gem,
        Artifact,
        MagicItem,
        Relic
    }
    internal class Treasure
    {
        public string Name;
        public string Description;
        public int TreasureId;
        public List<TreasureType> types = new List<TreasureType>();

        public void pickUp(Treasure TreasureObject)
        {
            if (this.types.Contains(TreasureType.Gold))
            {
                Console.WriteLine("You picked up " + this.Name + " nice work, home slice!");
            }
            if (this.types.Contains(TreasureType.Gem))
            {
                Console.WriteLine("You picked up " + this.Name + " way to go, Idaho!");
            }
            if (this.types.Contains(TreasureType.Artifact))
            {
                Console.WriteLine("You picked up " + this.Name + "... Lucky!!");
            }
            if (this.types.Contains(TreasureType.MagicItem))
            {
                Console.WriteLine("You picked up " + this.Name + " love this for you!");
            }
            if (this.types.Contains(TreasureType.Relic))
            {
                Console.WriteLine("You picked up " + this.Name + " best day EVER!!!");
            }
            else
            {
                Console.WriteLine(Name + " is not a valid treasure type.");
            }
        }
    }
}
