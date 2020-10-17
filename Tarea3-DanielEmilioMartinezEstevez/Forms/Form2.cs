using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_DanielEmilioMartinezEstevez.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero = 0, KM = 0, MI = 0;
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en Blanco");
                textBox1.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox1.Text);

            KM = numero * 1.60934;
            MI = numero * 1609.34;

            label5.Text = Convert.ToString(MI);
            label4.Text = Convert.ToString(KM);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double numero = 0, DOL = 0, EUR = 0;
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en blanco");
                textBox1.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox2.Text);

            DOL = numero / 24.63;
            EUR = numero / 28.83;

            label6.Text = Convert.ToString(DOL);
            label7.Text = Convert.ToString(EUR);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numero = 0, LTS = 0;
            if(textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo en Blanco");
                textBox3.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox3.Text);
            LTS = numero * 4.54609;

            label15.Text = Convert.ToString(LTS);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double numero = 0, CM = 0;
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en Blanco");
                textBox4.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox4.Text);
            CM = numero / 2.54;

            label14.Text = Convert.ToString(CM);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double numero = 0, MIN = 0;
            if (textBox6.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en Blanco");
                textBox6.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox6.Text);
            MIN = numero * 1440;

            label16.Text = Convert.ToString(MIN);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double numero = 0, ONZ = 0;
            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en Blanco");
                textBox5.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox5.Text);
            ONZ = numero * 16;

            label17.Text = Convert.ToString(ONZ);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double numero = 0, PIE = 0;
            if (textBox7.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en Blanco");
                textBox7.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox7.Text);
            PIE = numero * 3.281;

            label24.Text = Convert.ToString(PIE);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double numero = 0, MIN = 0;
            if (textBox9.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en Blanco");
                textBox9.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox9.Text);
            MIN = numero * 10080;

            label25.Text = Convert.ToString(MIN);
        }
    }
}
