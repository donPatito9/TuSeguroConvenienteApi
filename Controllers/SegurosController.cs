using Microsoft.AspNetCore.Mvc;
using TuSeguroConvenienteApi.Models;
using TuSeguroConvenienteApi.Persistence;

namespace TuSeguroConvenienteApi.Controllers
{
      
        [ApiController]
        [Route("api/tuseguroconvenienteapi")]
        public class SegurosController : ControllerBase
        {
            private readonly DbContext _dbContext;

            public SegurosController(DbContext dbContext)
            {
                _dbContext = dbContext;
            }

            //api/tuseguroconvenienteapi/GET
            [HttpGet]
            public IActionResult GetAll()
            {

                var seguro = _dbContext.Seguros.Where(d => !d.IsDeleted).ToList();

                return Ok(seguro);
            }

            //api/tuseguroconvenienteapi/3fa85f64-5717-4562-b3fc-2c963f66afa6 POST
            [HttpPost]
            public IActionResult Post(Seguro seguro)
            {

                _dbContext.Seguros.Add(seguro);

                return CreatedAtAction(nameof(GetById), new { id = seguro.Id }, seguro);

            }

            //api/tuseguroconvenienteapi/3fa85f64-5717-4562-b3fc-2c963f66afa6 GET
            [HttpGet("{id}")]
            public IActionResult GetById(Guid id)
            {

                var seguro = _dbContext.Seguros.Where(d => !d.IsDeleted).SingleOrDefault(d => d.Id == id);

                if (seguro is null) { return NotFound(); }

                return Ok(seguro);

            }

            //api/tuseguroconvenienteapi/3fa85f64-5717-4562-b3fc-2c963f66afa6/usuario
            [HttpPost("{id}/usuario")]
            public IActionResult PostUsuario(Guid id, Usuario usuario)
            {

                var seguro = _dbContext.Seguros.SingleOrDefault(d => d.Id == id);

                if (seguro is null) { return NotFound(); }

                seguro.Usuarios.Add(usuario);

                return NoContent();
            }

            //api/tuseguroconvenienteapi/3fa85f64-5717-4562-b3fc-2c963f66afa6 PUT
            [HttpPut("{id}")]
            public IActionResult Update(Guid id, Seguro input)
            {

                var seguro = _dbContext.Seguros.SingleOrDefault(d => d.Id == id);

                if (seguro is null) { return NotFound(); }

                seguro.Update(input.Categoria, input.TipoDePago, input.Descripcion, input.IsNewUsed);

                return NoContent();
            }

            //api/tuseguroconvenienteapi/3fa85f64-5717-4562-b3fc-2c963f66afa6 DELETE
            [HttpDelete("{id}")]
            public IActionResult Delete(Guid id)
            {
                var seguro = _dbContext.Seguros.SingleOrDefault(d => d.Id == id);

                if (seguro is null) { return NotFound(); }

                seguro.Delete();
                return NoContent();

            }

        }
    }
