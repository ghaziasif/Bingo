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
    public partial class Form1 : Form
    {
        public void linecheck()
        {
            if(Program.done[0]==1)
            {
                pictureBox4.Visible = true;
     
            }
            if (Program.done[1] == 1)
            {
                pictureBox1.Visible = true;
            }
            if (Program.done[2] == 1)
            {
                pictureBox2.Visible = true;
            }
            if (Program.done[3] == 1)
            {
                pictureBox3.Visible = true;
            }
            if (Program.done[4] == 1)
            {
                pictureBox5.Visible = true;
            }
            if (Program.done[5] == 1)
            {
                pictureBox6.Visible = true;
            }
            if (Program.done[6] == 1)
            {
             
                pictureBox7.Visible = true;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
            }
            if (Program.done[7] == 1)
            {

                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox7.Visible = false;
            }
            
            if ((Program.done[6] == 1) && (Program.done[7] == 1))
            {
                
                pictureBox7.Visible = false;

                pictureBox8.Visible = false;

                pictureBox9.Visible = true;

            }  
        }
        public void olinecheck()
        {
            if (Program.odone[0] == 1)
            {
                pictureBox13.Visible = true;

            }
            if (Program.odone[1] == 1)
            {
                pictureBox15.Visible = true;
            }
            if (Program.odone[2] == 1)
            {
                pictureBox14.Visible = true;
            }
            if (Program.odone[3] == 1)
            {
                pictureBox12.Visible = true;
            }
            if (Program.odone[4] == 1)
            {
                pictureBox11.Visible = true;
            }
            if (Program.odone[5] == 1)
            {
                pictureBox10.Visible = true;
            }
            if (Program.odone[6] == 1)
            {

                pictureBox16.Visible = true;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (Program.odone[7] == 1)
            {

                pictureBox17.Visible = true;
                pictureBox16.Visible = false;
                pictureBox18.Visible = false;
            }

            if ((Program.odone[6] == 1) && (Program.odone[7] == 1))
            {

                pictureBox16.Visible = false;

                pictureBox17.Visible = false;

                pictureBox18.Visible = true;

            }
        }
        public  void checkkk()
        {
            if ((Program.pick[0] == 1) && (Program.pick[1] == 1) && (Program.pick[2] == 1))
            {
                Program.done[0] = 1;
               
               
            }

            if ((Program.pick[3] == 1) && (Program.pick[4] == 1) && (Program.pick[5] == 1))
            {
                Program.done[1] = 1;
            } if ((Program.pick[6] == 1) && (Program.pick[7] == 1) && (Program.pick[8] == 1))
            {
                Program.done[2] = 1;
                
                
            }
            if ((Program.pick[0] == 1) && (Program.pick[3] == 1) && (Program.pick[6] == 1))
            {
               
                Program.done[3] = 1;
        }
            if ((Program.pick[1] == 1) && (Program.pick[4] == 1) && (Program.pick[7] == 1))
            {
                Program.done[4] = 1;
                
            }
            if ((Program.pick[2] == 1) && (Program.pick[5] == 1) && (Program.pick[8] == 1))
            { 
                Program.done[5] = 1;
                }


            if ((Program.pick[2] == 1) && (Program.pick[4] == 1) && (Program.pick[6] == 1))
            {

                Program.done[6] = 1;
                
            } if ((Program.pick[0] == 1) && (Program.pick[4] == 1) && (Program.pick[8] == 1))
            {
                Program.done[7] = 1;
            } //return Program.done;
        }



        public void ocheckkk()
        {
            if ((Program.opick[0] == 1) && (Program.opick[1] == 1) && (Program.opick[2] == 1))
            {
                Program.odone[0] = 1;

            }

            if ((Program.opick[3] == 1) && (Program.opick[4] == 1) && (Program.opick[5] == 1))
            {
                Program.odone[1] = 1;

            } if ((Program.opick[6] == 1) && (Program.opick[7] == 1) && (Program.opick[8] == 1))
                Program.odone[2] = 1;
            if ((Program.opick[0] == 1) && (Program.opick[3] == 1) && (Program.opick[6] == 1))
                Program.odone[3] = 1;
            if ((Program.opick[1] == 1) && (Program.opick[4] == 1) && (Program.opick[7] == 1))
                Program.odone[4] = 1;
            if ((Program.opick[2] == 1) && (Program.opick[5] == 1) && (Program.opick[8] == 1))
                Program.odone[5] = 1;


            if ((Program.opick[2] == 1) && (Program.opick[4] == 1) && (Program.opick[6] == 1))
                Program.odone[6] = 1;
            if ((Program.opick[0] == 1) && (Program.opick[4] == 1) && (Program.opick[8] == 1))
                Program.odone[7] = 1;
        //    return Program.odone;
        }

        public int checko()
        {
            if ((Program.opickcheck[0] == 1) && (Program.opickcheck[1] == 1) && (Program.opickcheck[2] == 1))
            {
                Program.odonecheck[0] = 1;

            }

            if ((Program.opickcheck[3] == 1) && (Program.opickcheck[4] == 1) && (Program.opickcheck[5] == 1))
            {
                Program.odonecheck[1] = 1;

            } if ((Program.opickcheck[6] == 1) && (Program.opickcheck[7] == 1) && (Program.opickcheck[8] == 1))
                Program.odonecheck[2] = 1;
            if ((Program.opickcheck[0] == 1) && (Program.opickcheck[3] == 1) && (Program.opickcheck[6] == 1))
                Program.odonecheck[3] = 1;
            if ((Program.opickcheck[1] == 1) && (Program.opickcheck[4] == 1) && (Program.opickcheck[7] == 1))
                Program.odonecheck[4] = 1;
            if ((Program.opickcheck[2] == 1) && (Program.opickcheck[5] == 1) && (Program.opickcheck[8] == 1))
                Program.odonecheck[5] = 1;


            if ((Program.opickcheck[2] == 1) && (Program.opickcheck[4] == 1) && (Program.opickcheck[6] == 1))
                Program.odonecheck[6] = 1;
            if ((Program.opickcheck[0] == 1) && (Program.opickcheck[4] == 1) && (Program.opickcheck[8] == 1))
                Program.odonecheck[7] = 1;
           // return Program.odonecheck;
            int resss=0; 
            for(int ee=0;ee<8;ee++)
             {
                 resss = resss + Program.odonecheck[ee]; 
             }
             return resss;
        }

        private void HideShow(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                pictureBox4.Visible = true;
            else if (e.KeyCode == Keys.H)
                pictureBox4.Visible = false;
        }
       
        public void win ()
        {
            int sum1 = Program.done.Sum();
            int sum2 = Program.odone.Sum();
            if ((sum1 >= 3) && (sum2 >= 3))
            {
                MessageBox.Show("DRAW");
             }
            else if (sum1 >= 3)
            {
                MessageBox.Show("You won!!!!!!!");
            }
            else if (sum2 >= 3)
            {
                MessageBox.Show("You Lost!!!!");
            }
            else sum1 = sum2;
         
            
            }

public void play (int x)
        {
            
                int[] o = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int indexx = Array.IndexOf(Program.oarr, x);
                textBox2.Text += x.ToString();
                opp_done(x);
                //Program.opick[indexx] = 1;
                ocheckkk();
                olinecheck();
             //   win();
                if (Program.done.Sum() < 3)
                {
                    //checking heuristics at every place
                for (int r = 0; r < 9; r++)
                {
                    for (int counter = 0; counter < 9; counter++)
                    {
                        Program.opickcheck[counter] = Program.opick[counter];
                        if (counter < 8)
                            Program.odonecheck[counter] = 0;

                    }
                    if (Program.opickcheck[r] == 0)
                    {
                        Program.opickcheck[r] = 1;
                        o[r] = checko();

                    }
                }

                // Taking decision

                int maxValue = o.Max();
                int max = o.ToList().IndexOf(maxValue);

                int sum = Program.odone.Sum();
                int val, vall;
                if (sum == o[max])
                {
                    if (Program.opick[4] == 0)
                    {
                        Program.opick[4] = 1;
                         ocheckkk();
                        val = Program.oarr[4];
                        vall = Array.IndexOf(Program.arr, val);
                        //    textBox1.Text = val.ToString();
                        textBox1.Text += val.ToString();
                        Program.pick[vall] = 1;
                         checkkk();
                        opp_done(val);
                        //    win();
                    }
                    else
                    {
                        int k = 0;

                        while (Program.opick[k++] == 1) ;
                        Program.opick[k - 1] = 1;
                         ocheckkk();

                        val = Program.oarr[k - 1];
                        vall = Array.IndexOf(Program.arr, val);
                        //    textBox1.Text = val.ToString();
                        textBox1.Text += val.ToString();
                        Program.pick[vall] = 1;
                        checkkk();
                        opp_done(val);
                        //      win();
                    }
                }
                else
                {
                    Program.opick[max] = 1;
                     ocheckkk();
                    // int val;
                    val = Program.oarr[max];
                    // int vall;
                    vall = Array.IndexOf(Program.arr, val);
                    textBox1.Text += val.ToString();

                    Program.pick[vall] = 1;
                    checkkk();
                    opp_done(val);
                    //    win();
                }

                switch (vall)
                {
                    case 0:
                        {
                            A1.Text = "X\n\n" + Program.arr[0].ToString();

                            break;
                        }
                    case 1:
                        {
                            button1.Text = "X\n\n" + Program.arr[1].ToString();
                            break;
                        }
                    case 2:
                        {
                            button2.Text = "X\n\n" + Program.arr[2].ToString();
                            break;
                        }
                    case 3:
                        {
                            button3.Text = "X\n\n" + Program.arr[3].ToString();
                            break;
                        }
                    case 4:
                        {
                            button4.Text = "X\n\n" + Program.arr[4].ToString();
                            break;
                        }
                    case 5:
                        {
                            button5.Text = "X\n\n" + Program.arr[5].ToString();
                            break;
                        }
                    case 6:
                        {
                            button6.Text = "X\n\n" + Program.arr[6].ToString();
                            break;
                        }
                    case 7:
                        {
                            button7.Text = "X\n\n" + Program.arr[7].ToString();
                            break;
                        }
                    case 8:
                        {
                            button8.Text = "X\n\n" + Program.arr[8].ToString();
                            break;
                        }

                }

            } linecheck();

            olinecheck();                          
    win();

    
                      //return 0; 
        }
public void opp_done(int s)
{
    int aa=Array.IndexOf(Program.oarr, s);
    if (aa == 0)
    {
        button16.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
    }
    else
            if (aa == 1)
    {
        button17.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }
    else
                if (aa == 2)
    {
        button18.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }else
                    if (aa == 3)
    {
        button13.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }
    else
                        if (aa == 4)
    {
        button14.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }
    else
                            if (aa == 5)
    {
        button15.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }
    else if (aa == 6)
    {
        button10.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }
    else if (aa == 7)
    {
        button11.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }
    else if (aa == 8)
    {
        button12.Text = "X\n\n" + Program.oarr[aa].ToString();
        Program.opick[aa]=1;
           
    }
   

}


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((Program.pick[6] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                button6.Text = "X\n\n" + Program.arr[6].ToString();

                Program.pick[6] = 1;
                checkkk();

                play(Program.arr[6]);
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            if ((Program.pick[0] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                A1.Text = "X\n\n" + Program.arr[0].ToString();
                Program.pick[0] = 1;
                checkkk();

                play(Program.arr[0]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Program.pick[1] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                button1.Text = "X\n\n" + Program.arr[1].ToString();

                Program.pick[1] = 1;
                checkkk();

                play(Program.arr[1]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((Program.pick[2] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                Program.pick[2] = 1;
                button2.Text = "X\n\n" + Program.arr[2].ToString();

                checkkk();

                play(Program.arr[2]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((Program.pick[5] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                Program.pick[5] = 1;
                button5.Text = "X\n\n" + Program.arr[5].ToString();
                checkkk();

                play(Program.arr[5]);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((Program.pick[4] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                Program.pick[4] = 1;
                button4.Text = "X\n\n" + Program.arr[4].ToString();
                checkkk();

                play(Program.arr[4]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if ((Program.pick[3] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                Program.pick[3] = 1;
                button3.Text = "X\n\n" + Program.arr[3].ToString();
                checkkk();

                play(Program.arr[3]);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if ((Program.pick[8] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                Program.pick[8] = 1;
                button8.Text = "X\n\n" + Program.arr[8].ToString();
                checkkk();

                play(Program.arr[8]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((Program.pick[7] != 1) && ((Program.done.Sum() < 3) && (Program.odone.Sum() < 3)))
            {
                Program.pick[7] = 1;
                button7.Text = "X\n\n" + Program.arr[7].ToString();
                checkkk();

                play(Program.arr[7]);

            }
        }

       
        private void button9_Click_1(object sender, EventArgs e)
        {
            A1.Enabled = true;

            button1.Enabled = true;

            button2.Enabled = true; button3.Enabled = true; button4.Enabled = true; button5.Enabled = true; button6.Enabled = true; button7.Enabled = true; button8.Enabled = true;
            A1.Text = Program.arr[0].ToString();
            button1.Text = Program.arr[1].ToString();
            button2.Text = Program.arr[2].ToString();
            button3.Text = Program.arr[3].ToString();
            button4.Text = Program.arr[4].ToString();
            button5.Text = Program.arr[5].ToString();
            button6.Text = Program.arr[6].ToString();
            button7.Text = Program.arr[7].ToString();
            button8.Text = Program.arr[8].ToString();
            
            // opponents game

            button18.Text = Program.oarr[2].ToString();
            button17.Text = Program.oarr[1].ToString();
            button16.Text = Program.oarr[0].ToString();
            button13.Text = Program.oarr[3].ToString();
        
            button14.Text = Program.oarr[4].ToString();
       
            button15.Text = Program.oarr[5].ToString();
        
            button10.Text = Program.oarr[6].ToString();
        
            button11.Text = Program.oarr[7].ToString();
        
            button12.Text = Program.oarr[8].ToString();
            button9.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

      

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showOpponentsGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox19.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

     
        
    }
}
