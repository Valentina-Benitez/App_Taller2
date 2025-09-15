using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerente
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_ojoAbierto_Click(object sender, EventArgs e)
        {
            textBox4_contraseña.PasswordChar = ' ';
            pictureBox2_ojoAbierto.Visible = false;
            pictureBox3_ojoCerrado.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_ojoCerrado_Click(object sender, EventArgs e)
        {
            textBox4_contraseña.PasswordChar = ' ';
            pictureBox2_ojoAbierto.Visible = true;
            pictureBox3_ojoCerrado.Visible = false;
        }

        private void button1_iniciar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
