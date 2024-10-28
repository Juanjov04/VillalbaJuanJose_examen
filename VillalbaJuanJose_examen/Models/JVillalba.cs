using System.ComponentModel.DataAnnotations;

namespace VillalbaJuanJose_examen.Models
{
    public class JVillalba
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float peso { get; set; }
        public bool genero { get; set; }
        public DateTime fecha { get; set; }
    }
}
