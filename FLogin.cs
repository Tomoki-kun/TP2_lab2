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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbContra.Text == "" && tbUsuario.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los datos antes de cerrar la ventana.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
