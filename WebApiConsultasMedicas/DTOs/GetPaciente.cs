namespace WebApiConsultasMedicas.DTOs
{
    public class GetPaciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public string telefono { get; set; }
        public List<GetConsulta> Consulta { get; set; }
        public GetPaciente Paciente { get; set; } 
    }
}
