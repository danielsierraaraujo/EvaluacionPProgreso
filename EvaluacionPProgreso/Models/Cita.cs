using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionPProgreso.Models
{
    public enum MotivoCita
    {
        Vacunacion,
        RevisionGeneral,
        Cirugia
    }

    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Fecha de Visita")]
        [DataType(DataType.DateTime)]
        public DateTime FechaVisita { get; set; }

        [Required]
        public MotivoCita Motivo { get; set; }

        [Range(0, 999)]
        public decimal Tarifa { get; set; }

        [Display(Name = "¿Requiere Medicación?")]
        public bool RequiereMedicacion { get; set; }

        public int MascotaId { get; set; }
        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; }
    }
}
