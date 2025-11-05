using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitasMedicas.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]
        public int id_paciente { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string apellidos { get; set; }
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
        public string email { get; set; }
       
        public DateOnly fechaNacimiento { get; set; }

    }
}