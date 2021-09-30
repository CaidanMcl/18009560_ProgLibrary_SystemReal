using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18009560_ProgLibrary_System
{
    class GenericUtility<T>
    {
        public bool Compare(T x,T y)
        {
            if (x.GetType(). Equals(y))
                return true;
            else 
                return false;
        }
    }
}
