using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApiConsultasMedicas.DTOs;


namespace WebApiConsultasMedicas.Controllers
{
    public class MedicoController
    {
        private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public MedicoController(ApplicationDbContext context)
        {
            this.dbContext = context;
            this.mapper = mapper;
            this.configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetConsulta>>> Get()
        {

            var consulta = await dbContext.Consulta.ToListAsync();
            return mapper.Map<List<GetConsulta>>(consulta);
        }
    }
}
