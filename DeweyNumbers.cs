using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18009560_ProgLibrary_System
{
    public class DeweyNumbers
    {

        public int Callnumbers { get; set; }
        public string LettersCall { get; set; }

        public DeweyNumbers(int callnumbers, string lettersCall)
        {
            Callnumbers = callnumbers;
            LettersCall = lettersCall;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Callnumbers, LettersCall);
        }




    }
}
