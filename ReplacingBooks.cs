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
    public partial class ReplacingBooks : Form
    {
        List<DeweyNumbers> numbers = new List<DeweyNumbers>();


        //Below not my list 
       // List<NumberAlphaDivider> listinlist = new List<NumberAlphaDivider>(); 


        char[] charsornum;




        public ReplacingBooks()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {//timer start when button pushed
           // this.timer1.Start();
            //Generates Callnumbers
            //Variable asssigned to random callnumbers method
            var generator = new RandomCallNumbers();
            var randomCallNumber = generator.RandomCallNumber();
            //Going through a list of random numbers
            var deweyNumber = generator.RandomNumber(0, 999);

            //For loop generating 10 numbers and adding to numbers list
            for (int i = 0; i < 10; i++)
            {
                var charGenerator = generator.RandomCallNumber();
                MessageBox.Show($"The random string of chars is {charGenerator}");
                numbers.Add(charGenerator);
                lb2.Items.Add(charGenerator.ToString());
            }

            


            //var sortedList = numbers.OrderBy(x => x.Callnumbers);

            //listinlist = new List<NumberAlphaDivider>();



            //foreach (var i in numbers)
            //{
            //    charsornum = i.ToString().ToCharArray();
            //}


            //for (int i = 0; i < charsornum.Length; i++)
            //{
            //    MessageBox.Show(charsornum[i].ToString());
            //}

        }




        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ReplacingBooks_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            progressBar1.Maximum = 10;
           


            //moves call numbers between listbox
            lb1.Items.Add(lb2.SelectedItem);
            progressBar1.Increment(1);
            int i = 0;
            i = lb2.SelectedIndex;
            lb2.Items.RemoveAt(i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //moves call numbers between listbox

            lb2.Items.Add(lb1.SelectedItem);
            int i = 0;
            i = lb1.SelectedIndex;
            lb1.Items.RemoveAt(i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //2nd list
        
            //var selectedFields = listBox1.Items.OfType<DeweyNumbers>().ToList();

            // List<DeweyNumbers> numbers2 = new List<DeweyNumbers>();

            //List<DeweyNumbers> selectedFields = listBox1.Items.OfType<DeweyNumbers>().ToList();


   
            
           // numbers.AddRange(listBox1.Items.OfType<DeweyNumbers>());
        //  List<DeweyNumbers> numbers = listBox1.Items.OfType<DeweyNumbers>().ToList();

            //Number list but sorted in acending order
            var sortedList = numbers.OrderBy(x => x.Callnumbers).ToList();

            //Compares sprted list with user list
            int i = 0;
            foreach (var value in sortedList)
            {
                //charsornum = i.ToString().ToCharArray();
                if (value.Callnumbers.Equals(sortedList[i]))
                {
                    MessageBox.Show("Well Done ");
                }
                else
                {
                    MessageBox.Show("failed");
                }
                i++;
            }












            //  string[] arr = new string[listBox1.Items.Count];
            //    string[] arr2 = new string[sortedList.Count];

            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    arr[i] = arr2[i];

            //    if (arr[i] != arr2[i])
            //    {
            //        MessageBox.Show("Wrong done");
            //    }
            //   else if (arr[i] == arr2[i])
            //    {
            //        MessageBox.Show("Well done");
            //    }





        }
                //Utility u = new Utility();
                //GenericUtility<DeweyNumbers> gu = new GenericUtility<DeweyNumbers>();

                //if()

                //MessageBox.Show(gu.Compare(numbers,sortedList));
            
        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Maximum = lb1.Items.Count;
            //progressBar1.Value = 0;

            //if ( lb1.Items.Count > 0)
            //{
            //    lb1.Items.RemoveAt(0);
            //    progressBar1.Increment(1);
            //    lb2.Text = lb1.Items.Count.ToString();
            //}
            //else
            //{
            //    timer1.Enabled = false;
            //}
            //this.progressBar1.Increment(1);
        }
    }
}
    