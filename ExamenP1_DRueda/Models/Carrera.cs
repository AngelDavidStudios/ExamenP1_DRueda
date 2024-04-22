using System.ComponentModel.DataAnnotations;

namespace ExamenP1_DRueda.Models
{
    public class Carrera
    {
        [Key]
        public int id_carrera { get; set; }
        public string nombre_carrera { get; set; }
        public string campus { get; set; }
        public int numero_semestres { get; set; }
    }
}
