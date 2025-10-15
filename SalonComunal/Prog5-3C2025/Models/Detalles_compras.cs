using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class Detalles_compras
    {
        [Key]
        [Required]
        public int DRL_ID { get; set; }
        [DisplayName("Nombre del producto")]
        [Required]
        public int DRL_CANTIDAD { get; set; }
        [Required]
        public float DRL_COSTO { get; set; }
        [DisplayName("Descripcion del producto")]
        [Required]
        public int Producto { get; set; }
        [Required]
        public int Compras { get; set; }
        public Detalles_compras()
        {
        }
        public Detalles_compras(int id, int cantidad, float costo, int pr_id, int cp_id)
        {
            DRL_ID = id;
            DRL_CANTIDAD = cantidad;
            DRL_COSTO = costo;
            Producto = pr_id;
            Compras = cp_id;
        }
    }
}
