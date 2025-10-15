using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class Compras
    {
        [Key]
        [Required]
        public int CPS_ID { get; set; }
        [DisplayName("Nombre del producto")]
        [Required]
        public DateTime CPS_FECHA { get; set; }
        [Required]
        public int Usuario { get; set; }
        public Compras()
        {
        }
        public Compras(int id, DateTime fecha, int us_id)
        {
            CPS_ID = id;
            CPS_FECHA = fecha;
            Usuario = us_id;
        }
    }
}
