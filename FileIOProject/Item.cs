using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public enum ItemType
    {
        Weapon,
        Armor,
        Consumable,
        QuestItem,
        Key,
        Lockable
    }
    public class Item
    {
        public string Name;
        public string Description;
        //public ItemType Type;

        public int KeyId;
        bool isLocked = false;

        public List<ItemType> types = new List<ItemType>();

        public void useKey(Item LockableObject)
        {
            if (this.types.Contains(ItemType.Key))
            {
                if (LockableObject.types.Contains(ItemType.Lockable))
                {
                    if (this.KeyId == LockableObject.KeyId)
                    {
                        LockableObject.isLocked = !LockableObject.isLocked;
                        var msg = LockableObject.isLocked ? "locked" : "unlocked";
                        Console.WriteLine($"{LockableObject.Name} has been {msg} using {Name}.");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} does not fit {LockableObject.Name}.");
                    }
                }
                else
                {
                    Console.WriteLine($"{LockableObject.Name} is not lockable.");
                }
            } else

            {
                Console.WriteLine($"{this.Name} is not a key.");
            }
        }
    }
}
