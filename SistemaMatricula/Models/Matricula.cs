﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMatricula.Models
{
    public class Matricula
    {
        public int id_estudiante { get; set; }
        public int id_curso { get; set; }
        public DateTime fecha_matricula { get; set; }
    }
}