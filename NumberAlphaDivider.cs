using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18009560_ProgLibrary_System
{
   public class NumberAlphaDivider
    {

        public string book;
        public List<char> bookchars;

        public string Book { get => book; set => book = value; }
        public List<char> Bookchars { get => bookchars; set => bookchars = value; }
        public NumberAlphaDivider()
        {

        }
        public NumberAlphaDivider(string book, List<char> bookchars)
        {
            this.book = book;
            this.bookchars = bookchars;
        }
    }
}
