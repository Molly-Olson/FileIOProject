using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    public enum TokenType
    {
        verb,
        subject
    }
    public class Token
    {
        public TokenType Name;
        public string Value;
        public Token(TokenType name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
