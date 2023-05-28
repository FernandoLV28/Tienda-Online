using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp3.Shared.Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"), MaxLength(100)]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatoria"), MaxLength(100)]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio"), MaxLength(10)]
        public string? Precio { get; set; }
    }
}
