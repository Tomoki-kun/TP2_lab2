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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
    }
}
