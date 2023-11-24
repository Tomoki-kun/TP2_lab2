using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    class Usuario
    {
        public string[,] usuario = { { "ricardo", "raka" }, { "12345", "877563" } };

        protected string Nombre { get; set; }
        protected string Contra { get; set; }


        public Usuario(string n, string c)
        {
            Nombre = n;
            Contra = c;
        }

    }
}

