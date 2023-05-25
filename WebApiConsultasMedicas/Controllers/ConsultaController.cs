using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApiConsultasMedicas.DTOs;
using WebApiConsultasMedicas.Entidades;

namespace WebApiConsultasMedicas.Controllers
{
    [ApiController]
    [Route("Consultas")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsMedico")]
    public class ConsultaController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public ConsultaController(ApplicationDbContext context, IMapper mapper, IConfiguration configuration)
        {
            this.dbContext = context;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsMedico")]
        public async Task<ActionResult> Post(ConsultaCreacion consultaCreacion)
        {
            var existeConsulta = await dbContext.Consulta.AnyAsync(x => x.Fecha == consultaCreacion.Fecha);

            if (existeConsulta)
            {
                return BadRequest($"Ya existe una consulta con esa fecha {consultaCreacion.Fecha}");
            }


            var consulta = mapper.Map<Consulta>(consultaCreacion);
            dbContext.Add(consulta);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsMedico")]
        public async Task<ActionResult> Put(ConsultaCreacion consultaCreacion, int id)
        {

            var exist = await dbContext.Consulta.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }

            var consulta = mapper.Map<Consulta>(consultaCreacion);
            consulta.Id = id;

            if (consulta.Id != id)
            {
                return BadRequest("El id dela consulta no coincide con el establecido en la url.");
            }

            dbContext.Update(consulta);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

      
        [HttpDelete("{id:int}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsMedico")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeConsulta = await dbContext.Consulta.AnyAsync(x => x.Id == id);
            if (!existeConsulta)
            {
                return NotFound("La consulta no fue encontrada.");
            }

            dbContext.Remove(new Consulta()
            {
                Id = id
            });

            await dbContext.SaveChangesAsync();
            return Ok();
        }




    }
}
