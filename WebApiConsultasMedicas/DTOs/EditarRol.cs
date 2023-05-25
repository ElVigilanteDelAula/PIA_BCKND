using System.ComponentModel.DataAnnotations;

namespace WebApiConsultasMedicas.DTOs
{
    public class EditarRol
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
