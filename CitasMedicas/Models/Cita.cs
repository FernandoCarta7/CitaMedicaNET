using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitasMedicas.Models
{
    [Table("Cita")]
    public class Cita
    {
        [Key]
        public int id_cita { get; set; }

        public DateTime fecha_cita { get; set; }
    }
}