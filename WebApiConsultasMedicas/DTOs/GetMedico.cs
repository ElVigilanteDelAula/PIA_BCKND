namespace WebApiConsultasMedicas.DTOs
{
    public class GetMedico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public List<GetConsulta> Consulta { get; set; }
        public List<GetDetallesPaciente> DetallesPacientes { get; set; }
    }
}
