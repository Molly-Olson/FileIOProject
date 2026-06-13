using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{ 
    public delegate void Action(Game game, List<Token> tokens);
    internal class LookupTable : Dictionary<string, Action>
    {
        public LookupTable()
        {
            Command c = new Command();
            this.Add("attack", c.attack);
            Add("help", c.help);
            Add("quit", c.quit);
            Add("exit", c.quit);
            Add("look", c.look);
            Add("move", c.move);
            Add("die", c.die);
            Add("sleep", c.sleep);
            Add("usekey", c.useKey);
            Add("unlock", c.useKey);
            Add("show", c.showInventory);
            //Add("stats", c.showStats);
            Add("inventory", c.showInventory);
            Add("save", c.save);
            Add("pickup", c.pickUp);
            Add("get", c.pickUp);
            Add("drop", c.drop);
            Add("release", c.drop);
        }
    }
}
