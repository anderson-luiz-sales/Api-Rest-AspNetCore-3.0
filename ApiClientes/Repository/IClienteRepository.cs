using ApiClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClientes.Repository
{
    public interface IClienteRepository
    {
        void Add(Clientes user);
        IEnumerable<Clientes> GetAll();
        Clientes Find(long id);
        void Remove(long id);
        void Update(Clientes user);

    }
}
