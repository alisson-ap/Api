using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        public static List<Cliente> _cliente; 
        public ClientesController(){

            if(_cliente == null)
            {
                _cliente = new List<Cliente>();
            }
        }
        [HttpPost]

        public IActionResult Cadastrar(Cliente nome)
        {
            _cliente.Add(nome);

            return StatusCode(201);
        }

    }
}