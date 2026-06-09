using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileIOProject
{

	public class PlayerNotFoundException : Exception
    {
		public PlayerNotFoundException(string msg) : base(msg)
		{

		}
	}
}
