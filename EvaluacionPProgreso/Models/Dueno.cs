using System.ComponentModel.DataAnnotations;

namespace EvaluacionPProgreso.Models
{
    public class Dueno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        [Display(Name = "Nombre del Propietario")]
        public string Nombre { get; set; }

        [Range(1, 120, ErrorMessage = "La edad debe estar entre 1 y 120.")]
        public int Edad { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 10000, ErrorMessage = "El saldo debe estar entre 0 y 10000.")]
        public decimal AbonoCita { get; set; }

        [EmailAddress(ErrorMessage = "Debe ser un correo electrónico válido.")]
        public string CorreoElectronico { get; set; }

        [Display(Name = "Cliente Activo")]
        public bool EsActivo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }
        public string? SierraD { get; set; }
    }
}
