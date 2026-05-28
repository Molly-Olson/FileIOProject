using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject
{
    internal class Tokenizer
    {
        public List<Token>? Tokenize(string s)
        {
            List<Token> list = new List<Token>();
            var parts = s.ToLower().Split(" ");
            list.Add(new Token(TokenType.verb, parts[0]));

            for (int i = 1; i < parts.Length; i++)
            {
                list.Add(new Token(TokenType.subject, parts[i]));
            }
            return list.Count > 0 ? list : null;
        }
    }
}
