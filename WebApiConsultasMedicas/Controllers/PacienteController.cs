using Microsoft.AspNetCore.Mvc;
using WebApiConsultasMedicas.Entidades;


namespace WebApiConsultasMedicas.Controllers
{
    [ApiController]
    [Route("api/paciente")]
    public class PacienteController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public PacienteController(ApplicationDbContext context)
        {

            _context = context;
        }


      
    }
}
