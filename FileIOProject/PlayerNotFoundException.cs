using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    internal class PlayerNotFoundException : Exception
    {
        public PlayerNotFoundException(string msg) : base(msg)
        {
        }
    }
}
