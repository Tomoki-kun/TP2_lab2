using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TP2_Lab.Formularios
{
    public partial class ImageViewForm : Form
    {
        private List<Image> images;

        public ImageViewForm(List<Image> images)
        {
            InitializeComponent(); 
            this.images = images;

            // Configurar el formulario modal
            this.Text = "Imágenes";

            // Mostrar las imágenes en el formulario modal
            DisplayImages();

        }

        private void DisplayImages()
        {
            // Calcular la posición inicial del PictureBox
            int x = 10;
            int y = 10;

            // Mostrar cada imagen en un PictureBox
            foreach (Image image in images)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(200, 200); // Tamaño deseado para el PictureBox
                pictureBox.Location = new Point(x, y);

                // Agregar el PictureBox al formulario modal
                this.Controls.Add(pictureBox);

                // Actualizar la posición para el siguiente PictureBox
                x += pictureBox.Width + 10; // Espacio entre PictureBox
            }
        }
    }
}
