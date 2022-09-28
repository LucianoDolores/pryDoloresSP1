using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryDoloresSP1
{
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter localidades = new StreamWriter("./localidades.txt", true);
            localidades.WriteLine(mskIDloc.Text + " "  + " " + txtLocalidad.Text);
            MessageBox.Show("Cargado con exito.");

            localidades.Close();

            txtLocalidad.Text = "";

            mskIDloc.Text = "";
        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDloc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblidentLoc_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
