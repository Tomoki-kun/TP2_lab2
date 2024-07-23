using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Lab
{
    public partial class FPropiedad : Form
    {
        private List<Image> images = new List<Image>(); // Lista para almacenar las imágenes
        public FPropiedad()
        {
            InitializeComponent();
        }

        private void rBCasas_CheckedChanged(object sender, EventArgs e)
        {
            gBCasas.Visible = true;
            gBHoteles.Visible = false;
            cbxDesayuno.Checked = false;
        }

        private void rBHoteles_CheckedChanged(object sender, EventArgs e)
        {
            gBCasas.Visible = false;
            gBHoteles.Visible = true;
            if (rBHoteles.Checked)
            {
                cbxDesayuno.Checked = true;
            }
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

        public List<Image> ListaImagenes 
        {
            get { return images; }
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            FileImagen.Filter = "Imagenes | *.jpg;*.jpeg;*.png";
            FileImagen.FileName = "";
            FileImagen.Multiselect = true;
            FileImagen.InitialDirectory = Path.Combine(Application.StartupPath, "Resource");
            if (FileImagen.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in FileImagen.FileNames)
                {
                    Image image = Image.FromFile(fileName);
                    images.Add(image); // Agregar la imagen a la lista
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (images.Count == 0)
            {
                try { 
                if (rBCasas.Checked)
                {
                    Image image = Image.FromFile(Application.StartupPath + "\\Resource\\CasaDefault.jpg");
                    images.Add(image);
                }
                if (rBHoteles.Checked)
                {
                    Image image = Image.FromFile( Application.StartupPath + "\\Resource\\HotelDefault.jpg");
                    images.Add(image);
                }
             }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FPropiedad_Load(object sender, EventArgs e)
        {
            cBTipoHabitacion.SelectedIndex = 0;
        }
    }
}
