using ApiCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClientes.Repository
{
    public interface IClienteRepository
    {
        void Add(Cliente user);
        IEnumerable<Cliente> GetAll();
        Cliente Find(long id);
        void Remove(long id);
        void Update(Cliente user);

    }
}
