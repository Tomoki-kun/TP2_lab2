using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Lab
{
    class Empleado:Usuario
    {

        public Empleado(string user, string pas) : base(user, pas) 
        { 
        }


        public void CambiarPassword(string nuevaP) 
        {
            if(nuevaP != Contra)
            {
                Contra = nuevaP;
            }
            else
            {
                MessageBox.Show("no puede poner la misma contraseña");
            }
        }


    }
}
