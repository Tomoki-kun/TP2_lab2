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
        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tBpasword.Text == "" && tBusuario.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los datos antes de cerrar la ventana.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
