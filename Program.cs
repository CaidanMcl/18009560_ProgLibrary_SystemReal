using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18009560_ProgLibrary_System
{
    static class Program
    {

        public static List<DeweyNumbers> callNum = new List<DeweyNumbers>();

        public static bool sorted = false;
       // public static DeweyNumbers LoggedInUser = new DeweyNumbers();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
