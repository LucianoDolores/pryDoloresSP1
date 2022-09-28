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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter cultivos = new StreamWriter("./cultivos.txt", true);
            cultivos.WriteLine(mskIDcul.Text + " " + txtCultivos.Text);

            MessageBox.Show("Cargado correctamente!");

            cultivos.Close();

            txtCultivos.Text = "";

            mskIDcul.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskIDcul_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCultivos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
