using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18009560_ProgLibrary_System
{
   public class RandomCallNumbers
    {


        // Instantiate random number generator.  
        // It is better to keep a single Random instance 
        // and keep using Next on the same instance.  
        private readonly Random random = new Random();


        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            //Unicode/ASCII Letters are divided into two blocks
            //The first group contains the dewey decimal system
            //The second group containing the authors names

            //Char is a single unicode character  
            char offset = lowerCase ? 'a' : 'A';
            // A...Z or a..z: length = 26 
            const int lettersOffset = 26;

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[3];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new string(stringChars);

            //for (var i = 0; i < size; i++)
            //{
            //    var @char = (char)_random.Next(offset, offset + lettersOffset);
            //    builder.Append(@char);
            //}
            //return lowerCase ? builder.ToString().ToLower() : builder.ToString();
            return finalString;
        }

        // Generates a random password.  
        // 4-LowerCase + 4-Digits + 2-UpperCase  
        public DeweyNumbers RandomCallNumber()
        {

            var callNumberBuilder = new StringBuilder();

            // 3-Digits between 000 and 999
            return new DeweyNumbers(RandomNumber(0, 999), RandomString(3, false));

        }
    }
}
