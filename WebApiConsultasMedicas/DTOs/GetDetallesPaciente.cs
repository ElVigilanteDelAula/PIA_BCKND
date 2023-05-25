using WebApiConsultasMedicas.Entidades;

namespace WebApiConsultasMedicas.DTOs
{
    public class GetDetallesPaciente
    {
        public int PacienteId { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public string Enfermedades { get; set; }

    }
}
