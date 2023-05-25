namespace WebApiConsultasMedicas.DTOs
{
    public class GetConsulta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<GetPaciente> Paciente { get; set;}
        public List<GetMedico> Medico { get; set; } 
    }
}
