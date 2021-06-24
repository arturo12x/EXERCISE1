using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCISE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb1.SelectedIndex = 0;
            lbl1.Text = cb1.Text;
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = EXERCISE1.Properties.Resources.triangulo;
                    lbl1.Text = cb1.Text;
                    label1.Text = "BASE";
                    label2.Text = "HEIGHT";
                    break;
                case 1:
                    pictureBox1.Image = EXERCISE1.Properties.Resources.cuadrado;
                    lbl1.Text = cb1.Text;
                    label1.Text = "BASE";
                    label2.Text = "HEIGHT";
                    break;
                case 2:
                    pictureBox1.Image = EXERCISE1.Properties.Resources.decagono_regular;
                    lbl1.Text = cb1.Text;
                    label1.Text = "PERIMETER";
                    label2.Text = "APOTHEMA";

                    break;
                 
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            double a1, h1, side,b1;
            bool validar=false;
          
           


                if (textBox1.Text=="")
                {
                    textBox1.BackColor = Color.Red;
                    MessageBox.Show("INAVLID " + label1.Text + " VALUES");
                    validar = true;

                }

                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Red;
                    MessageBox.Show("INAVLID " + label2.Text + " VALUES");
                    validar = true;
                }

                if (validar == true)
      {
          return;
      }
                b1 = Convert.ToDouble(textBox1.Text);
                h1 = Convert.ToDouble(textBox2.Text);
          
            switch (cb1.SelectedIndex)
            {

                case 0:
                      a1 = (h1 * b1)/2;
            textBox3.Text = a1.ToString();

                    break;
                case 1:
                      a1 = h1 * b1;
            textBox3.Text = a1.ToString();

                    break;
                case 2:
                    b1 = b1 * 10;
                    a1 = (h1*b1) / 2;
            textBox3.Text = a1.ToString();

                    break;
            }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
           && !char.IsDigit(e.KeyChar)
           && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // solo se permite un punto decimal
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
         && !char.IsDigit(e.KeyChar)
         && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // solo se permite un punto decimal
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
