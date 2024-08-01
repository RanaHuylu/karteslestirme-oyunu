using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace OYUN
{
    public partial class Form1 : Form
    {   
        Label firstClicked = null;
        Label secondClicked = null;

        Random random = new Random();
        List<string> icons = new List<string>()
    {
        "H", "H", "Y", "Y", "Z", "Z", "B", "B",
        "l", "l", "j", "j", "K", "K", "P", "P"
    };


        SoundPlayer ses = new SoundPlayer();
        private void AssignIconsToSquares()
        {
            
            string dizin = Application.StartupPath + "\\s.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) 
            return;
            Label clickedLabel = sender as Label;
            
            if (clickedLabel != null)
            {
               
                if (clickedLabel.ForeColor == Color.Black)
                    return;                    
                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;

                        return;
                    }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                CheckForWinner();
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    lblSkor.Text=(Convert.ToInt32(lblSkor.Text)+1).ToString();

                    return;
                }
                
                timer1.Start();
                

            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            timer1.Stop();
           

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("HEPSİ EŞLEŞTİ", "BRAVO");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pBarSkor.Value--;
            lblSayac.Text = pBarSkor.Value.ToString();
            if(lblSayac.Text=="0")
            {
                timer1.Enabled = false;
                label1 =null;
                label2 = null;
                label3 = null;
                label4 = null;
                label5 = null;
                label6 = null;
                label7 = null;
                label8 = null;
                label9 = null;
                label10 = null;
                label11= null;
                label12= null;
                label13 = null;
                label14 = null;
                label15 = null;
                label16 = null;
                


            }

        }
    }
    }

