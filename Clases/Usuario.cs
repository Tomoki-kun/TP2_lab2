using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    [Serializable]
    public class Usuario: IComparable
    {
        public string Nombre { get; set; }
        public string Contra { get; set; }


        public Usuario(string n, string c)
        {
            Nombre = n;
            Contra = c;
        }
        
        /*public int CompareTo(object obj)
        {
            int nombreComparison = Nombre.CompareTo(((Usuario)obj).Nombre);

            if (nombreComparison == 0)
            {
                // Si los nombres son iguales, compara por contraseña
                return Contra.CompareTo(((Usuario)obj).Contra);
            }

            return nombreComparison;
        }*/

        public int CompareTo(object obj)
        {
            return this.Nombre.CompareTo(((Usuario)obj).Nombre);
        }
    }
}
