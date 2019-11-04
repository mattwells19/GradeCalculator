using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grade_Average_Wells_02
{
    public partial class Form1 : Form
    {
        int x, grd, z;
        double avg, sum, one, two, three, four;
        Random gen = new Random();
        Boolean own = false;
        int[] ray = new int[4];
        
        public Form1()
        
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            sum = 0;
            grd = 0;
            avg = 0;
            pA.Visible = false; pB.Visible = false; pC.Visible = false; pD.Visible = false; pF.Visible = false;
            if (own == true)
            {
                Double.TryParse(txtG1.Text, out one);
                Double.TryParse(txtG2.Text, out two);
                Double.TryParse(txtG3.Text, out three);
                Double.TryParse(txtG4.Text, out four);

                sum = one + two + three + four;
                avg = sum / 4;
                MessageBox.Show("Your average is " + avg + college((int)avg).ToString());
                btnLetter.Visible = true;
                listBox1.Visible = false;

            }
            else
            {
                for (x = 0; x < 4; x++)
                {
                    ray[x] = gen.Next(60, 101);
                    sum = sum + ray[x];
                    avg = sum / 4;
                }
                {

                    if (avg >= 93)
                    {
                        pA.Visible = true;
                        listBox1.Items.Add("AVG " + avg + college((int)avg).ToString() + abss((int)avg).ToString());
                    }
                    if (avg >= 85 & avg <= 92)
                    {
                        pB.Visible = true;
                        listBox1.Items.Add("AVG " + avg + college((int)avg).ToString() + abss((int)avg).ToString());
                    }
                    if (avg >= 77 & avg <= 84)
                    {
                        pC.Visible = true;
                        listBox1.Items.Add("AVG " + avg + college((int)avg).ToString() + abss((int)avg).ToString());
                    }
                    if (avg >= 70 & avg <= 76)
                    {
                        pD.Visible = true;
                        listBox1.Items.Add("AVG " + avg + college((int)avg).ToString() + abss((int)avg).ToString());
                    }
                    if (avg <= 69)
                    {
                        pF.Visible = true;
                        listBox1.Items.Add("AVG " + avg + college((int)avg).ToString() + abss((int)avg).ToString());
                    }
                }
                MessageBox.Show("Your average is " + avg.ToString());
                btnLetter.Visible = true;

               for (z = 0; z < 4; z++)
                    if (ray[z] >= 93)
                       listBox1.Items.Add(ray[z] + "  A");
                    else if (ray[z] >= 85 & ray[z] <= 92)
                        listBox1.Items.Add(ray[z] + "  B");
                   else if (ray[z] >= 77 & ray[z] <= 84)
                        listBox1.Items.Add(ray[z] + "  C");
                   else if (ray[z] >= 70 & ray[z] <= 76)
                        listBox1.Items.Add(ray[z] + "  D");
                    else if (ray[z] <= 69)
                       listBox1.Items.Add(ray[z] + "  F");






                if (this.Width == 300)
                {
                    this.Width += 308;
                    this.Height += 142;
                }


            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            pA.Visible = false; pB.Visible = false; pC.Visible = false; pD.Visible = false; pF.Visible = false;
            if (avg >= 93)
                pA.Visible = true;
            
            if (avg >= 85 & avg <= 92)
                pB.Visible = true;
           
            if (avg >= 77 & avg <= 84)
                pC.Visible = true;
            
            if (avg >= 70 & avg <= 76)
                pD.Visible = true;
          
            if (avg <= 69)
                pF.Visible = true;
            
        }
        



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Matt Wells. 2/4/14. V2");
        }

        private void iWantToAdMyOwnGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            own = true;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
            txtG1.Visible = true; txtG2.Visible = true; txtG3.Visible = true; txtG4.Visible = true;
            if (this.Width == 300)
            {
                this.Width += 308;
                this.Height += 142;

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            own = false;
            x = 0;
            avg = 0;
            grd = 0;
            sum = 0;
            one = 0;
            two = 0;
            three = 0;
            four = 0;
            pA.Visible = false; pB.Visible = false; pC.Visible = false; pD.Visible = false; pF.Visible = false;
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false;
            txtG1.Visible = false; txtG2.Visible = false; txtG3.Visible = false; txtG4.Visible = false;
            btnLetter.Visible = false;
            listBox1.Items.Clear();
            if (this.Width == 608)
            {
                this.Width -= 308;
                this.Height -= 142;
            }
            if (this.Width == 816)
            {
                this.Width -= 516;
                this.Height -= 142;
            }
        }

        private void moreLoopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false;
            txtG1.Visible = false; txtG2.Visible = false; txtG3.Visible = false; txtG4.Visible = false;
            if (this.Width == 300)
            {
                this.Width += 308;
                this.Height += 142;

            }
            if (this.Width == 608)
            {
                this.Width += 208;
                
            }
        }

        private void btnDW_Click(object sender, EventArgs e)
        {
            sum = 0;
            grd = 0;
            avg = 0;
            x = 0;
            do
            {
                    grd = gen.Next(60, 101);
                    sum = sum + grd;
                    avg = sum / 4;
                    x += 1;
            }
            while  (x < 4);
            MessageBox.Show("Your average is " + avg.ToString());
            btnLetter.Visible = true;
        }

        private void btnDU_Click(object sender, EventArgs e)
        {
           
            
       
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            sum = 0;
            grd = 0;
            avg = 0;
            x = 0;
            while (x < 4)
            {
                grd = gen.Next(60, 101);
                sum = sum + grd;
                avg = sum / 4;
                x += 1;
            }
            MessageBox.Show("Your average is " + avg.ToString());
            btnLetter.Visible = true;
        }

        private void uhhThatsItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If the program is only displaying your average or it is too small for putting in your grades, simply close and re-open the program. What has happened is the width of the form has changed dis-allowing it to resize.", "HELP!!");
      
        }

        public string college(int x)
    {
       
                        if (x >= 90)
                            return "  A";
                        else if (x >= 80)
                            return "  B";
                        else if (z >= 70)
                            return "  C";
                        else if (x >= 60)
                            return "  D";
                        else 
                            return "  F";
    }

        public string abss(int x)
        {
            if (x >= 93)
                return "  A";
            else if (x >= 85)
                return "  B";
            else if (z >= 77)
                return "  C";
            else if (x >= 70)
                return "  D";
            else
                return "  F";
        }

    
            
        }
    }

