using Microsoft.EntityFrameworkCore;

namespace ApiClientes.Models
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options)
            : base(options)
        { }

        public DbSet<Clientes> Cliente {get; set;}
    }
}