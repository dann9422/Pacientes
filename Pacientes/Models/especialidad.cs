﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pacientes.Models
{
    public class especialidad
    {
        [Key]
        public int idespecialidad { get; set; }
        public string descripcion { get; set; }
    } 
}
