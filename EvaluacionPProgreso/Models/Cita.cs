using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionPProgreso.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Visita")]
        public DateTime FechaVisita { get; set; }

        [Required]
        [Display(Name = "Motivo de la Visita")]
        public MotivoVisita Motivo { get; set; }

        [Display(Name = "Tarifa")]
        [DataType(DataType.Currency)]
        public decimal Tarifa { get; set; }

        [Display(Name = "¿Requiere Medicación?")]
        public bool RequiereMedicacion { get; set; }
        
        public int MascotaId { get; set; }
        [ForeignKey("MascotaId")]
        public Mascota? Mascota { get; set; }

        public void CalcularTarifa()
        {
            switch (Motivo)
            {
                case MotivoVisita.Vacunacion:
                    Tarifa = 30m;
                    break;
                case MotivoVisita.RevisionGeneral:
                    Tarifa = 20m;
                    break;
                case MotivoVisita.Cirugia:
                    Tarifa = 100m;
                    break;
            }
        }
    }
    public enum MotivoVisita
    {
        Vacunacion,
        RevisionGeneral,
        Cirugia
    }
}
