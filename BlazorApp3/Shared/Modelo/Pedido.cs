using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BlazorApp3.Shared.Modelo
{
    public class Pedido
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="La fecha no puede ser vacio")]
        public DateTime Fecha { get; set; }

        public double Total { get; set; }

        public int ClientesId { get; set; }

        public virtual Cliente? Clientes { get; set; }
        public virtual ICollection<Producto>? Productos { get; set; }

    }
}

