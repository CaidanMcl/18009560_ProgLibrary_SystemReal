using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18009560_ProgLibrary_System
{
    class Utility
    {

        public bool Compare(int x, int y)
        {
            if (x == y)
                return true;
            else return false;
        }

        public bool Compare(string x, string y)
        {
            if (x.Equals(y))
                return true;
            else return false; 
        }
    }
}
