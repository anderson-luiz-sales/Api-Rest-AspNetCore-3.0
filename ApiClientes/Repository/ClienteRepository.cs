using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiClientes.Models;

namespace ApiClientes.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteDbContext _context;
        public ClienteRepository(ClienteDbContext ctx)
        {
            _context = ctx;
        }   
        public void Add(Clientes clientes)
        {
            _context.Cliente.Add(clientes);
            _context.SaveChanges();
        }

        public Clientes Find(long id)
        {
            return _context.Cliente.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<Clientes> GetAll()
        {
            return _context.Cliente.ToList();
        }

        public void Remove(long id)
        {
            var entity = _context.Cliente.FirstOrDefault(u => u.Id == id);
            _context.Cliente.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Clientes cliente)
        {
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
        }
    }
}
