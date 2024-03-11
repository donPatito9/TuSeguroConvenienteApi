using Microsoft.AspNetCore.Mvc;
using TuSeguroConvenienteApi.Models;

// For more informationS on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TuSeguroConvenienteApi.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {

        // GET: api/<ClienteController>
        [HttpGet]
        [Route("listar")]
        public dynamic ListarCliente()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    ClienteId = 01,
                    NombreUser = "Robinson",
                    ApellidoUser = "Concha",
                    TelefonoUser = 0912332145,
                    TipoSeguroUser = "Seguro Automotriz"
                },
                new Cliente
                {
                   ClienteId = 02,
                    NombreUser = "Patricio",
                    ApellidoUser = "Concha",
                    TelefonoUser = 0912332146,
                    TipoSeguroUser = "Seguro de vida"
                }
            };
            return clientes;

        }

        // GET api/<ClienteController>/5
        [HttpGet]
        [Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic GuardarCliente(Cliente cliente)
        {
            cliente.ClienteId = 03;
            cliente.NombreUser = "Pablo";
            cliente.ApellidoUser = "Pedrovich";
            cliente.TelefonoUser = 0912332147;
            cliente.TipoSeguroUser = "Seguro Hogar";

            return new
            {
                success = true,
                message = "Cliente registrado satisfactoriamente",
                result = cliente

            };
        }

        [HttpPut]
        [Route("modificar")]
        public dynamic UpdateCliente(Cliente cliente)
        {
            cliente.ClienteId = 03;
            cliente.NombreUser = "Juan Paco Pedro";
            cliente.ApellidoUser = "De la Mar";
            cliente.TelefonoUser = 0912332147;
            cliente.TipoSeguroUser = "Seguro Automotriz";

            return new
            {
                success = true,
                message = "Cliente Modificado satisfactoriamente",
                result = cliente


            };
        }
        [HttpDelete]
        [Route("eliminar")]
        public dynamic EliminarCliente(Cliente cliente)
        {
            cliente.ClienteId = 03;
            cliente.NombreUser = "Juan Paco Pedro";
            cliente.ApellidoUser = "De la Mar";
            cliente.TelefonoUser = 0912332147;
            cliente.TipoSeguroUser = "Seguro Automotriz";

            return new
            {
                success = true,
                message = "Cliente Eliminado satisfactoriamente",
                result = cliente
            };

        }
    }
}
