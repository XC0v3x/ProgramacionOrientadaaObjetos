using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_DanielEmilioMartinezEstevez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarea3_DanielEmilioMartinezEstevez.Forms.Form2 converiones = new Tarea3_DanielEmilioMartinezEstevez.Forms.Form2();
            converiones.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tarea3_DanielEmilioMartinezEstevez.Forms.Form3 Calculos = new Tarea3_DanielEmilioMartinezEstevez.Forms.Form3();
            Calculos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tarea3_DanielEmilioMartinezEstevez.Forms.Form4 ultimo = new Tarea3_DanielEmilioMartinezEstevez.Forms.Form4();
            ultimo.Show();
        }
    }
}
