using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiConsultasMedicas.Entidades;

namespace WebApiConsultasMedicas
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DetallesPaciente>()
                .HasKey(al => new { al.PacienteId});
        }

        public DbSet<Paciente> Paciente { get; set; }    

        public DbSet<Medico> Medico { get; set; }

        public DbSet<Consulta> Consulta { get; set; }

        public DbSet<DetallesPaciente> DetallesPaciente { get; set; } 
    }
}
