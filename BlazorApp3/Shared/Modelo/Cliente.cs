using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Shared.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"), MaxLength(100)]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La dirección es obligatoria"), MaxLength(100)]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio"), MaxLength (12), Phone]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio"), MaxLength(100), EmailAddress]
        public string? Correo { get; set; }
    }
}
