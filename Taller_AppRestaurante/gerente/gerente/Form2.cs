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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void lEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Empleados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Empleados());
        }

        private void AbrirFormHija(object formHija)
        {
            if(this.panelContenedor.Controls.Count >0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = formHija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
        }

        private void bEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Empleados());

        }
    }
}
