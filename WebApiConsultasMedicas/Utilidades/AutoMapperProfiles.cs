using AutoMapper;
using WebApiConsultasMedicas.DTOs;
using WebApiConsultasMedicas.Entidades;

namespace WebApiConsultasMedicas.Utilidades
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PacienteCreacion, Paciente>();
            CreateMap<Paciente, GetPaciente>();
            CreateMap<MedicoCreacion, Medico>();
            CreateMap<Medico, GetMedico>();
            CreateMap<ConsultaCreacion, Consulta>();
            CreateMap<Consulta, GetConsulta>();
            CreateMap<DetallesPacienteCreacion, DetallesPaciente > ();
            CreateMap<DetallesPaciente, GetDetallesPaciente>();
        }

        


    }
}
