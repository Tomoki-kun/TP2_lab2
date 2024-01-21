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
    public partial class FHuesped : Form
    {
        private List<TextBox> camposDeDatos;
        private Button btnAgregarCampo;
        public FHuesped()
        {
            InitializeComponent();
            InicializarUI();
        }
        private void InicializarUI()
        {
            // Inicializar la lista de campos
            camposDeDatos = new List<TextBox>();

            // Configurar el botón para agregar campos
            btnAgregarCampo = new Button();
            btnAgregarCampo.Text = "+";
            btnAgregarCampo.Click += BtnAgregarCampo_Click;

            // Agregar el botón al formulario
            Controls.Add(btnAgregarCampo);

            // Agregar un campo inicial
            AgregarCampo();
        }

        private void BtnAgregarCampo_Click(object sender, EventArgs e)
        {
            AgregarCampo();
        }

        private void AgregarCampo()
        {
            // Crear un nuevo TextBox
            TextBox nuevoCampo = new TextBox();

            // Configurar el nuevo campo
            nuevoCampo.Dock = DockStyle.Top;

            // Agregar el nuevo campo a la lista
            camposDeDatos.Add(nuevoCampo);

            // Agregar el nuevo campo al formulario
            Controls.Add(nuevoCampo);

            // Ajustar el tamaño del formulario
            Height += nuevoCampo.Height;
        }
    }
}
