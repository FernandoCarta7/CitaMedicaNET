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
        public string ?Nombres { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string ?Apellidos { get; set; }
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
        public string ?Email { get; set; }
       
        public DateOnly FechaNacimiento { get; set; }

    }
}