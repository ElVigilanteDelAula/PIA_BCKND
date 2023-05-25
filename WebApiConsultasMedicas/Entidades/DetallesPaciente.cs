namespace WebApiConsultasMedicas.Entidades
{
    public class DetallesPaciente
    {
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public string Enfermedades { get; set; }
        public Medico Medico { get; set; }
    }
}
