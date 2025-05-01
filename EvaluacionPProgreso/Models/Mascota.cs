using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionPProgreso.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string Raza { get; set; }

        [Range(0, 30)]
        public int Edad { get; set; }

        [StringLength(15)]
        public string Genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public int DuenoId { get; set; }
        [ForeignKey("DuenoId")]
        public Dueno? Dueno { get; set; }
    }
}
