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


        [HttpGet]
        public ActionResult <List<Paciente>> Get()
        {
            return new List<Paciente>()
            {
                new Paciente() { Id = 1, Nombre = "erick", Apellido = "Flores", Direccion="rio tula", Fecha_Nacimiento = "24/05/2002", Genero = "masculino", telefono= "(81) 1 7819120" }

            };
        }
    }
}
