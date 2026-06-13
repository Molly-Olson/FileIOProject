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
        Trap,
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
            }
            else

            {
                Console.WriteLine($"{this.Name} is not a key.");
            }
        }

        public void eatConsumable(Item ConsumableObject)
        {
            if (this.types.Contains(ItemType.Consumable))
            {
                Console.WriteLine("You... witty comment here... ");
                // increase or decrease depending on what consumable... also like how do I make those and use them?
            }
            else
            {
                Console.WriteLine($"Ha, that's fake. You can't eat {this.Name}. It's a display");
            }
        }
        public void useWeapon(Item WeaponObject)
        {
            if (this.types.Contains(ItemType.Weapon))
            {
                Console.WriteLine("You picked up dope weapon for travel mi amigo.");
                // I'm not sure how to use any of this stuff...
            }
            else
            {
                Console.WriteLine($"My friend, {this.Name} is not a weapon. That's dark, even for you.");
                // how do I call out the player by name (player.Name) did not work
            }
        }
        public void wearArmor(Item ArmorObject)
        {
            if (this.types.Contains(ItemType.Armor))
            {
                Console.WriteLine("You look SHARP! No. Literally, stay away from me.");
                // I want this to increase defense but how do 
            }
            else
            {
                Console.WriteLine($"Bro, {this.Name} is not armor. You can't wear that! At least not at your age.");
                // how do I call out the player by name 
            }
        }
        public void getQuest(Item QuestObject)
        {
            if (this.types.Contains(ItemType.QuestItem))
            {
                Console.WriteLine("Secret hidden awesome sauce QUEST ITEM found! WaaAAAHHHhhhhaaaaahhHAHaHAHAHAHAa.......");
                // collect all items to win kinda thing? How do?
            }
            else
            {
                Console.WriteLine($"Nah, {this.Name} is just a piece of trash, you know like most of your wardrobe choices.");
                // I must be in a mood, chad is sassy today!
            }
        }
    }
}
