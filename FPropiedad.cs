using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Lab
{
    public partial class FPropiedad : Form
    {
        public FPropiedad()
        {
            InitializeComponent();
        }

        private void rBCasas_CheckedChanged(object sender, EventArgs e)
        {
            gBCasas.Visible = true;
            gBHoteles.Visible = false;
        }

        private void rBHoteles_CheckedChanged(object sender, EventArgs e)
        {
            gBCasas.Visible = false;
            gBHoteles.Visible = true;
        }

        private void rBcasaDia_CheckedChanged(object sender, EventArgs e)
        {
            if (rBcasaDia.Checked)
            {
                gbCasaXDia.Visible = true;
            }
            else
            {
                gbCasaXDia.Visible = false;
            }
        }

        public string RutaImagen { get; private set; }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            FileImagen.Filter = "Imagenes | *.jpg;*.jpeg;*.png";
            if (FileImagen.ShowDialog() == DialogResult.OK)
            {
                RutaImagen = FileImagen.FileName;
            }
        }
    }
}
