namespace WebApiConsultasMedicas.Controllers
{
    public class ConsultaController
    {
        private readonly ApplicationDbContext _context;

        public ConsultaController(ApplicationDbContext context)
        {

            _context = context;
        }
    }
}
