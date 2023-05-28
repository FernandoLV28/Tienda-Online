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
        [Required(ErrorMessage ="La fecha es obligatoria")]
        public DateTime Fecha { get; set; }

        public double Total { get; set; }

        public int ClienteId { get; set; }
        [Required, Range (1,2, ErrorMessage ="Debe seleccionar método de pago")]
        public int Metodo_Pago { get; set; }

    }
}

