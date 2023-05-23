using Microsoft.EntityFrameworkCore;
using WebApiConsultasMedicas.Entidades;

namespace WebApiConsultasMedicas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
          
        }

        public DbSet<Paciente> Paciente { get; set; }    

    }
}
