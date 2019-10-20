using ApiClientes.Models;
using ApiClientes.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiClientes.Controllers
{
    [Route("api/[Controller]")]
    public class ClientesController : Controller
    {
        private readonly  IClienteRepository _clienteRepository;

        public ClientesController(IClienteRepository clienteRepo)
        {
            _clienteRepository = clienteRepo;
        }

        [HttpGet]
        public IEnumerable<Clientes> GetAll()
        {
            return _clienteRepository.GetAll();
        }
    }
}
