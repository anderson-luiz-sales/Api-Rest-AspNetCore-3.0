using ApiCliente.Models;
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
        private readonly IClienteRepository _clienteRepository;

        public ClientesController(IClienteRepository clienteRepo)
        {
            _clienteRepository = clienteRepo;
        }

        [HttpGet]
        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetCliente")]
        public IActionResult GetById(long id)
        {
            var cliente = _clienteRepository.Find(id);
            if (cliente == null)
                return NotFound();

            return new ObjectResult(cliente);
        }
    }
}
