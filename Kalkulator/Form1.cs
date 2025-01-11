using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class GlowneOkno : Form
    {
        public GlowneOkno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "1";
            }
            if (buttonNrLiczby.Text == "L2")
            {
                textLiczba2.Text = textLiczba2.Text + "1";
            }
        }

        private void textLiczba1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNrLiczby_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1/L2")
            {
                buttonNrLiczby.Text = "L1";
                textLiczba1.ReadOnly = false;
            }
            else
            {
                if (buttonNrLiczby.Text == "L1")
                {
                    buttonNrLiczby.Text = "L2";
                    textLiczba1.ReadOnly = true;
                    textLiczba2.ReadOnly = false;
                }
                else
                {
                    buttonNrLiczby.Text = "L1";
                    textLiczba1.ReadOnly = false;
                    textLiczba2.ReadOnly = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "2";
            } else
            {
                textLiczba2.Text = textLiczba2.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "3";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "4";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "5";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "6";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "7";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "8";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "9";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = textLiczba1.Text + "0";
            }
            else
            {
                textLiczba2.Text = textLiczba2.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (buttonNrLiczby.Text == "L1")
            {
                textLiczba1.Text = "";
            }
            else
            {
                textLiczba2.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textLiczba1.Text != "" && textLiczba2.Text != "")
            {
                long w = 0;
                w = long.Parse(textLiczba1.Text) + long.Parse(textLiczba2.Text);
                string wynik = w.ToString();
                textWynik.Text = wynik;
            } else
            {
                textWynik.Text = "Błąd !!!";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textLiczba1.Text != "" && textLiczba2.Text != "")
            {
                long w = 0;
                w = long.Parse(textLiczba1.Text) - long.Parse(textLiczba2.Text);
                string wynik = w.ToString();
                textWynik.Text = wynik;
            } else
            {
                textWynik.Text = "Błąd !!!";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textLiczba1.Text != "" && textLiczba2.Text != "")
            {
                long w = 0;
                w = long.Parse(textLiczba1.Text) * long.Parse(textLiczba2.Text);
                string wynik = w.ToString();
                textWynik.Text = wynik;
            } else
            {
                textWynik.Text = "Błąd !!!";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textLiczba2.Text != "" && textLiczba2.Text != "0") 
            {
                double w = 0;
                w = double.Parse(textLiczba1.Text) / double.Parse(textLiczba2.Text);
                string wynik = w.ToString();
                textWynik.Text = wynik;
            } else {
                textWynik.Text = "Błąd !!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
