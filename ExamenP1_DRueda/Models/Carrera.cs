using System.ComponentModel.DataAnnotations;

namespace ExamenP1_DRueda.Models
{
    public class Carrera
    {
        [Key]
        public int IdCarrera { get; set; }
        [Required(ErrorMessage = "El nombre de la carrera es requerido.")]
        [StringLength(100, ErrorMessage = "El nombre de la carrera no puede exceder los 100 caracteres.")]
        public string? nombre_carrera { get; set; }

        [Required(ErrorMessage = "El campus es requerido.")]
        [StringLength(50, ErrorMessage = "El campus no puede exceder los 50 caracteres.")]
        public string? campus { get; set; }

        [Range(1, 10, ErrorMessage = "El número de semestres debe estar entre 1 y 10.")]
        public int? numero_semestres { get; set; }
    }

}
