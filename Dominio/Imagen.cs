﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Imagen
    {
        public int id { get; set; }
        public string UrlImagen { get; set; }

        public int idArticulo { get; set; }
    }

}
