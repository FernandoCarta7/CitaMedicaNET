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

        [ForeignKey(nameof(Paciente))]
        public int id_paciente { get; set; }
        public Paciente? Paciente { get; set; }


        [ForeignKey(nameof(Medico))]
        public int id_medico { get; set; }
        public Medico? Medico { get; set; }

        
    }
}