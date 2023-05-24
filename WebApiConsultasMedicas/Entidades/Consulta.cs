namespace WebApiConsultasMedicas.Entidades
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Receta { get; set; }
        public int PacienteId { get; set; }
        public Paciente paciente { get; set; }
        public int MedicoId { get; set; }
        public Medico medico { get; set; }
    }
}
