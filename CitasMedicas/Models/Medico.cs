using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitasMedicas.Models

{
[Table("Medico")]
    public class Medico
    {   
        [Key]
        public int id_medico { get; set; }
        [Required]
        public string ?Nombres { get; set; }

        [Required]
        public string ?Apellidos { get; set; }

        [Required]
        public string ?Especialidad { get; set; }


    }
}