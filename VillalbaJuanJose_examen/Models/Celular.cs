using System.ComponentModel.DataAnnotations;

namespace VillalbaJuanJose_examen.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        public String Modelo { get; set; }
        public string año { get; set; }
        public String precio { get; set; }
    }
}
