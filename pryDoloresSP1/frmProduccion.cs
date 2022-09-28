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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader lectorLocalidad = new StreamReader("./localidades.txt");
            StreamReader lectorCultivo = new StreamReader("./cultivos.txt");

            while (!lectorLocalidad.EndOfStream)
            {
                string informacionLocalidad = lectorLocalidad.ReadLine();

                cmbLocalidad.Items.Add(informacionLocalidad.Substring(5));

            }
            lectorLocalidad.Close();

            while (!lectorCultivo.EndOfStream)
            {
                string informacionCultivos = lectorCultivo.ReadLine();
                cmbCultivo.Items.Add(informacionCultivos.Substring(5));

            }
            lectorCultivo.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter producciones = new StreamWriter("./producciones.txt", true);
            producciones.WriteLine(cmbLocalidad.Text + " " + cmbCultivo.Text + " " + txtProduccion.Text);

            MessageBox.Show("Producción Cargada correctamente!");
            producciones.Close();
            txtProduccion.Text = "";
            txtProduccion.Focus();
            cmbLocalidad.Text = "";
            cmbCultivo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
