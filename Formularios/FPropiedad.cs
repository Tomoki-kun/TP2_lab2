﻿using System;
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

        public string RutaImagen { get; private set; }
        public string RutaImagen2 { get; private set; }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            FileImagen.Filter = "Imagenes | *.jpg;*.jpeg;*.png";
            for (int i = 0; i < 2; i++)
            {
                if (FileImagen.ShowDialog() == DialogResult.OK)
                {
                    if (i == 0)
                    {
                        RutaImagen = FileImagen.FileName;
                    }
                    else if (i == 1)
                    {
                        RutaImagen2 = FileImagen.FileName;
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (RutaImagen == null && RutaImagen2 == null)
            {
                if (rBCasas.Checked)
                {
                    RutaImagen = Application.StartupPath + "\\Resource\\CasaDefault.jpg";
                    RutaImagen2 = Application.StartupPath + "\\Resource\\CasaDefault.jpg";
                }
                if (rBHoteles.Checked)
                {
                    RutaImagen = Application.StartupPath + "\\Resource\\HotelDefault.jpg";
                    RutaImagen2 = Application.StartupPath + "\\Resource\\HotelDefault.jpg";
                }
            }
        }
    }
}