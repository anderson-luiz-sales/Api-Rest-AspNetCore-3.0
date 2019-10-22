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

        [HttpPost]
        public IActionResult Create([FromBody] Cliente cliente)
        {
            if (cliente == null)
                return BadRequest();

            _clienteRepository.Add(cliente);

            return CreatedAtRoute("GetCliente", new  { id = cliente.Id_Cli }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Cliente cliente)
        {
            if (cliente == null || cliente.Id_Cli != id)
                return BadRequest();

            var _cliente = _clienteRepository.Find(id);

            if (_cliente == null)
                return NotFound();

            _cliente.Nome = cliente.Nome;
            _cliente.Cidade = cliente.Cidade;
            _cliente.Telefone = cliente.Telefone;
            _cliente.Celular = cliente.Celular;
            _cliente.Email = cliente.Email;

            _clienteRepository.Update(_cliente);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var cliente = _clienteRepository.Find(id);

            if (cliente == null)
                return NotFound();

            _clienteRepository.Remove(id);
            return new NoContentResult();
        }
    }
}
