using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18009560_ProgLibrary_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRepB_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReplacingBooks form = new ReplacingBooks();
            form.Show();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {

        }

        private void btnCalln_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
