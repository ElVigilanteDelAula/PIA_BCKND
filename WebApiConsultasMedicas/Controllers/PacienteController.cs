using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiConsultasMedicas.Entidades;
using WebApiConsultasMedicas.DTOs;
using Microsoft.EntityFrameworkCore;

namespace WebApiConsultasMedicas.Controllers
{
    [ApiController]
    [Route("paciente")]
    public class PacienteController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly UserManager<IdentityUser> userManager;


        public PacienteController(ApplicationDbContext context, IMapper mapper, IConfiguration configuration)
        {
            this.dbContext = context;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsMedico")]
        public async Task<ActionResult> Post(PacienteCreacion PacienteCreacion)
        {

            var cantidadDePacientes = await dbContext.Paciente.CountAsync();
            if (cantidadDePacientes >= 101)
            {
                return BadRequest($"Ya se alcanzo el limite de Pacientes por medico");
            }

            var paciente = mapper.Map<Paciente>(PacienteCreacion);
            dbContext.Add(paciente);
            await dbContext.SaveChangesAsync();
            var PacienteDTO = mapper.Map<GetPaciente>(paciente);
            return CreatedAtRoute("obtenerPaciente", PacienteDTO);
        }

        [HttpDelete("{id:int}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsMedico")]
        public async Task<ActionResult> Delete(int id)
        {
            var existePaciente = await dbContext.Paciente.AnyAsync(x => x.Id == id);
            if (!existePaciente)
            {
                return NotFound("El paciente no fue encontrado.");
            }

            dbContext.Remove(new Paciente()
            {
                Id = id
            });

            await dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
