using ApiCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiClientes.Models
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options)
            : base(options)
        { }

        public DbSet<Cliente> Cliente {get; set;}
    }
}