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
        [Required(ErrorMessage = "El nombre no puede ser vacio"), MaxLength(100)]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La dirección no puede ser vacio"), MaxLength(100)]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "El telefono no puede ser vacio"), MaxLength (12), Phone]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El correo no puede ser vacio"), MaxLength(100), EmailAddress]
        public string? Correo { get; set; }

        public virtual ICollection<Pedido>? Pedidos { get; set; }
    }
}
