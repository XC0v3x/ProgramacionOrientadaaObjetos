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
    public partial class Form3 : Form
    {
        double Contador;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N1 = 0, N2 = 0, N3 = 0, Total = 0;
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error Campo Vacio");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error Campo Vacio");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error Campo Vacio");
                textBox3.Focus();
                return;
            }

            N1 = Convert.ToDouble(textBox1.Text);
            N2 = Convert.ToDouble(textBox2.Text);
            N3 = Convert.ToDouble(textBox3.Text);

            Total = N1 + N2 + N3;
            label5.Text = Convert.ToString(Total);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double nota = 0, promedio = 0;
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox4.Focus();
                return;
            }

            nota = Convert.ToDouble(textBox4.Text);
            Contador = nota + Contador;
            promedio = Contador / 4;
            label8.Text = Convert.ToString(promedio);
            listBox1.Items.Add(Convert.ToString(nota));
            textBox4.Text = " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Precio = 0, Cantidad = 0, Total = 0;
            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox5.Focus();
                return;
            }

            if (textBox6.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox6.Focus();
                return;
            }

            Precio = Convert.ToDouble(textBox6.Text);
            Cantidad = Convert.ToDouble(textBox5.Text);

            Total = Precio * Cantidad;

            label12.Text = Convert.ToString(Total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double HRS = 0, DIA = 0, Total = 0;
            if (textBox7.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox7.Focus();
                return;
            }

            if (textBox8.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox8.Focus();
                return;
            }

            HRS = Convert.ToDouble(textBox7.Text);
            DIA = Convert.ToDouble(textBox8.Text);

            Total = HRS * DIA;

            label13.Text = Convert.ToString(Total);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double BASE = 0, DIA = 0, HRSX = 0, Total = 0;
            if (textBox10.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox10.Focus();
                return;
            }

            if (textBox9.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox9.Focus();
                return;
            }

            if (textBox11.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox11.Focus();
                return;
            }

            BASE = Convert.ToDouble(textBox9.Text);
            DIA = Convert.ToDouble(textBox10.Text);
            HRSX = Convert.ToDouble(textBox11.Text);

            Total = (BASE * DIA) + (HRSX * (BASE * 0.5));

            label17.Text = Convert.ToString(Total);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double Base = 0, porcentaje = 0, Total = 0;
            if (textBox12.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox12.Focus();
                return;
            }

            if (textBox13.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el Campo esta vacio");
                textBox13.Focus();
                return;
            }

            Base = Convert.ToDouble(textBox12.Text);
            porcentaje = Convert.ToDouble(textBox13.Text);

            Total = Base + (Base * (porcentaje / 100));
            label25.Text = Convert.ToString(Total); 
        }

        double Edad = 0, Promedio = 0, contedad = 0;

        private void button12_Click(object sender, EventArgs e)
        {
            double numero = 0, total = 0;
            if (textBox15.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error no hay numero");
                textBox15.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox15.Text);
            total = numero * 2;
            label34.Text = Convert.ToString(total);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double numero = 0, total = 0;
            if (textBox15.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error no hay numero");
                textBox15.Focus();
                return;
            }
            numero = Convert.ToDouble(textBox15.Text);
            total = numero * numero;
            label35.Text = Convert.ToString(total);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double numero = 0, total = 0;
            if (textBox15.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error no hay numero");
                textBox15.Focus();
                return;
            }

            numero = Convert.ToDouble(textBox15.Text);
            total = numero * numero * numero;
            label36.Text = Convert.ToString(total);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Promedio = contedad / 10;
            label29.Text = Convert.ToString(Promedio);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox14.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta en blanco");
                    textBox14.Focus();
                    return; 
            }

            listBox2.Items.Add(textBox14.Text);
            Edad = Convert.ToDouble(textBox14.Text);
            contedad = Edad + contedad;
            
            
        }
    }
}
