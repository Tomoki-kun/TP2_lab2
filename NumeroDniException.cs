﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    class NumeroDniException:ApplicationException
    {
        public NumeroDniException():base("Error en el numero de DNI") { }
        public NumeroDniException(string msg) : base(msg) { }

        public NumeroDniException(string msg, Exception ex) : base(msg, ex) { }
    }
}
