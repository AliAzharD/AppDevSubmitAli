using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Ali_Azhar_D
{
    public partial class Form2 : Form
    {
        
        public int jmlTiket = 0;
        public bool[,] simpanMyArray;
        public Form2(string tiket, string playTime, bool[,] myArray)
        {
            InitializeComponent();
            simpanMyArray = myArray;
            jmlTiket = int.Parse(tiket);
            lblTiket.Text = "Jumlah Tiket: " + tiket;

           

            for (int b = 0; b < 10; b++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Button btnkursi = new Button();
                    // set the properties of the textbox
                    btnkursi.Name = "btn" +b.ToString() +k.ToString();
                    btnkursi.Text = "";
                    btnkursi.Size = new Size(40, 40);
                    if(k > 4)
                    {
                        btnkursi.Location = new Point((230 + (k * 40)), (100 + b * 40));
                    }
                    else
                    {
                        btnkursi.Location = new Point((150 + (k * 40)),(100 + b * 40));
                    }
                    btnkursi.Enabled = myArray[b,k];
                    if (myArray[b, k])
                    {
                        btnkursi.BackColor = Color.Green;
                    }
                    else
                    {
                        btnkursi.BackColor= Color.Orange;
                    }
                    btnkursi.Click += new EventHandler(btnkursi_Click);
                    //Add the button to the form
                    this.Controls.Add(btnkursi);
                }
            }
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnkursi_Click (object sender, EventArgs e)
        {
            
            Button clickedButton = (Button)sender;
            string filterNoKursi = new string (clickedButton.Name.Where(c => Char.IsDigit(c)).ToArray ());
            int noKursi = int.Parse(filterNoKursi);
            if (clickedButton.BackColor == Color.Blue)
            {

                
                
                jmlTiket++;
                clickedButton.BackColor = Color.Green;
                simpanMyArray[noKursi / 10, noKursi % 10] = true;
                lblTiket.Text = "Jumlah Tiket: "+ jmlTiket.ToString();

            }
            else
            {
                if(jmlTiket > 0)
                {
                    simpanMyArray[noKursi / 10, noKursi%10] = false;
                    clickedButton.BackColor= Color.Blue;
                    jmlTiket--;
                    lblTiket.Text = "Jumlah Tiket: " + jmlTiket.ToString();

                }

                
            }


        }
    }
}
