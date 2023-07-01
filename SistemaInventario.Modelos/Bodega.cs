﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int IdBodega { get; set; }
        [Required(ErrorMessage = "Nombre es Requerido")]
        [MaxLength(60, ErrorMessage ="Nombre debe ser máximo 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripción es Requerido")]
        [MaxLength(60, ErrorMessage = "Descripción debe ser máximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado requerido")]
        public bool Estado { get; set; }

    }
}
