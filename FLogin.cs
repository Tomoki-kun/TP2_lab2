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
        Usuario nuevoU = new Usuario();
        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = tBusuario.Text;
            string password = tBpasword.Text;

            if (user == nuevoU.usuario[0, 0] && password == nuevoU.usuario[1, 0])
            {
                MessageBox.Show("Bienvenido al sistema de reservas");
                button1.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto");
                tBusuario.Text = "";
                tBpasword.Text = "";
            }
        }
    }
}
