using ExamenP1_DRueda.Models;
using System.ComponentModel.DataAnnotations;

public class DRueda
{
    public int id { get; set; }

    [Required(ErrorMessage = "El nombre es requerido.")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "El pago de matrícula es requerido.")]
    [Range(0, 10000, ErrorMessage = "El pago de matrícula debe estar entre 0 y 10000.")]
    public decimal? pagoMatricula { get; set; }

    [Required(ErrorMessage = "Es necesario indicar si está matriculado.")]
    public bool? IsMatriculado { get; set; }

    [Required(ErrorMessage = "La fecha es requerida.")]
    public DateTime? Fecha { get; set; }

    [Required(ErrorMessage = "La carrera es requerida.")]
    public Carrera? SuCarrera { get; set; }
}

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
