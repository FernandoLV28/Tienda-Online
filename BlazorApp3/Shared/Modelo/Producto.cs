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
        [Required(ErrorMessage = "El nombre no puede ser vacio"), MaxLength(100)]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion no puede ser vacio"), MaxLength(100)]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El precio no puede ser vacio"), MaxLength(10)]
        public string? Precio { get; set; }
        public int ? PedidosId { get; set; }
        public virtual Pedido? Pedidos { get; set; }
    }
}
