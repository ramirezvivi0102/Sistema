﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class Categoria 
    {
        public int CategoriaID { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set;} 
        public Boolean Estado  { get; set; }
    }
}
