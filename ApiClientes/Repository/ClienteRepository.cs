using ApiCliente.Models;
using ApiClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClientes.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteDbContext _context;
        public ClienteRepository(ClienteDbContext ctx)
        {
            _context = ctx;
        }
        public void Add(Cliente clientes)
        {
            _context.Cliente.Add(clientes);
            _context.SaveChanges();
        }

        public Cliente Find(long id)
        {
            return _context.Cliente.FirstOrDefault(u => u.Id_Cli == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Cliente.ToList();
        }

        public void Remove(long id)
        {
            var entity = _context.Cliente.FirstOrDefault(u => u.Id_Cli == id);
            _context.Cliente.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
        }
    }
}
