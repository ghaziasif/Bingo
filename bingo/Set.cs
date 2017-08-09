using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo
{
    public partial class Set : Form

    {
        public Set()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                Form1 f = new Form1();
                f.Show();
                this.Visible = false;

                //Assigning numbers for opponents game
                var ran = new Random();
                Program.oarr = Enumerable.Range(1, 9).OrderBy(x => ran.Next()).ToArray();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[0] = Int32.Parse(tb.Text);
           
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            bool checkk=false;
            TextBox currenttb = (TextBox)sender;
            
            for(int i=1;i<9;i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;
             
            }
            if(checkk==false)
            {
               // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;
               
            }
            else 
            {
                MessageBox.Show(string.Format("Invalid Value" ));
                e.Cancel = true;
                
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[8] = Int32.Parse(tb.Text);
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[4] = Int32.Parse(tb.Text);
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[1] = Int32.Parse(tb.Text);
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[2] = Int32.Parse(tb.Text);
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[3] = Int32.Parse(tb.Text);
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[5] = Int32.Parse(tb.Text);
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[6] = Int32.Parse(tb.Text);
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "1" || tb.Text == "2" || tb.Text == "3" || tb.Text == "4" || tb.Text == "5" || tb.Text == "6" || tb.Text == "7" || tb.Text == "8" || tb.Text == "9")
                Program.arr[7] = Int32.Parse(tb.Text);
           
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 1)
                        i++;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 2)
                        i++;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 3)
                        i++;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 4)
                        i++;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 5)
                        i++;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 6)
                        i++;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 7)
                        i++;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            bool checkk = false;
            TextBox currenttb = (TextBox)sender;

            for (int i = 0; i < 9; i++)
            {
                if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                {
                    if (i == 8)
                        continue;
                    if (Int32.Parse(currenttb.Text) == Program.arr[i])
                    {
                        checkk = true;
                    }
                }
                else checkk = true;

            }
            if (checkk == false)
            {
                // if (currenttb.Text == "1" || currenttb.Text == "2" || currenttb.Text == "3" || currenttb.Text == "4" || currenttb.Text == "5" || currenttb.Text == "6" || currenttb.Text == "7" || currenttb.Text == "8" || currenttb.Text == "9")
                e.Cancel = false;

            }
            else
            {
                MessageBox.Show(string.Format("Invalid Value"));
                e.Cancel = true;

            }
        }
    }
}
