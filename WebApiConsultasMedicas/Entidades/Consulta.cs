namespace WebApiConsultasMedicas.Entidades
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int PacienteId { get; set; }
        public Paciente paciente { get; set; }
        public int MedicoId { get; set; }
        public Medico medico { get; set; }

    }
}
