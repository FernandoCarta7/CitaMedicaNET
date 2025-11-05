using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.Models
{
    public class Medico
    {
        private int IdMedico { get; set; }
        [Required]
        private string Nombres { get; set; }

        [Required]
        private string Apellidos { get; set; }
        
        [Required]
        private string Especialidad { get; set; }


    }
}