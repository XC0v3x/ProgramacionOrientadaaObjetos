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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double MTS, Total, Precio;
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox2.Focus();
                return;
            }

            MTS = Convert.ToDouble(textBox1.Text);
            Precio = Convert.ToDouble(textBox2.Text);

            Total = MTS * Precio;
            label5.Text = Convert.ToString(Total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Examen = 0, Acumulativo = 0, Nota = 0;
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox3.Focus();
                return;
            }

            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error el campo esta vacio");
                textBox4.Focus();
                return;
            }

            Examen = Convert.ToDouble(textBox3.Text);
            Acumulativo = Convert.ToDouble(textBox4.Text);
            Nota = Examen + Acumulativo;
            label11.Text = Convert.ToString(Nota);

        }
    }
}
