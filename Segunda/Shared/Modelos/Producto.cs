using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda.Shared.Modelos
{
    public class Producto
    {
        [Range(1,int.MaxValue,ErrorMessage ="Debe ser un entero positivo")]
        public int Id { get; set; }
        [Required(ErrorMessage ="No debe ser vacio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe seleccionar departamento")]
        public string? Departamento { get; set; }
    }
}
