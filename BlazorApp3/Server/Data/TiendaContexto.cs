using BlazorApp3.Shared.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Server.Data
{
    public class TiendaContexto : DbContext
    {
        public TiendaContexto(DbContextOptions<TiendaContexto> options) : base(options)
        {
            
        }
        public DbSet <Cliente> Clientes { get; set; }
        public DbSet <Producto> Productos { get; set; }
        public DbSet <Pedido> Pedidos { get; set; }
    }
}
