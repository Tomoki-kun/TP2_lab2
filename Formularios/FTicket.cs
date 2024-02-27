using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Lab
{
    public partial class FTicket : Form
    {

        private int pageNumber = 1;
        public FTicket()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch (Win32Exception)
            {
                MessageBox.Show("No se puede acceder al documento");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Ruta de la imagen de fondo
            string imagePath = Application.StartupPath + "\\Resource\\logo_transparent.png";

            // Carga la imagen desde el archivo
            using (Image image = Image.FromFile(imagePath))
            {

                // Establece la transparencia de la imagen
                float transparency = 0.5f; // Modifica este valor para ajustar la transparencia
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(new ColorMatrix { Matrix33 = transparency }, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                
                // Calcula la posición y el tamaño de la imagen para que ocupe la mayor área posible en el centro de la página
                float aspectRatio = (float)image.Width / image.Height;
                float maxWidth = e.PageBounds.Width;
                float maxHeight = e.PageBounds.Height;
                float imageWidth = Math.Min(maxWidth, maxHeight * aspectRatio);
                float imageHeight = imageWidth / aspectRatio;
                float x1 = (e.PageBounds.Width - imageWidth) / 2;
                float y1 = (e.PageBounds.Height - imageHeight) / 2;

                // Dibuja la imagen en el centro de la página
                e.Graphics.DrawImage(image, new Rectangle((int)x1, (int)y1, (int)imageWidth, (int)imageHeight), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            }


            if (pictureBox.Image != null)
            {
                e.Graphics.DrawImage(pictureBox.Image, new Point(50, 50));
            }

            // Imprimir líneas desde el ListBox
            int y = 300;
            foreach (var item in lBticket.Items)
            {
                e.Graphics.DrawString(item.ToString(), lBticket.Font, Brushes.Black, new PointF(50, y));
                y += (int)e.Graphics.MeasureString(item.ToString(), lBticket.Font).Height;
            }
            string texto;
            if (pageNumber == 1)
                texto = "Original";
            else texto = "Duplicado";
            Font font = new Font("Arial", 10,FontStyle.Bold);
            SizeF textSize = e.Graphics.MeasureString(texto, font);
            float x = (e.PageBounds.Width - e.Graphics.VisibleClipBounds.Width) + e.Graphics.VisibleClipBounds.Width - textSize.Width - 50;
            float yd = e.PageBounds.Height - textSize.Height - 50;
            e.Graphics.DrawString(texto, font, Brushes.Black, new PointF(x, yd));
            pageNumber++;

            // Si deseas imprimir dos veces la misma página
            if (pageNumber <= 2)
            {
                // Establece HasMorePages a true para indicar que hay otra página por imprimir
                e.HasMorePages = true;
            }
            else
            {
                // Reinicia el número de página para la próxima impresión
                pageNumber = 1;
            }
        }


        
    }
}
