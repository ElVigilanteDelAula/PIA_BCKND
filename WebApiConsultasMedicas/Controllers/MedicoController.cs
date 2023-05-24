namespace WebApiConsultasMedicas.Controllers
{
    public class MedicoController
    {
        private readonly ApplicationDbContext _context;

        public MedicoController(ApplicationDbContext context)
        {

            _context = context;
        }
    }
}
