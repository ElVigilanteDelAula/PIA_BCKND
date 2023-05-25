namespace WebApiConsultasMedicas.Entidades
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public List<Consulta> Consulta { get; set; }
        public List<DetallesPaciente> DetallesPacientes { get; set; }
    }
}
