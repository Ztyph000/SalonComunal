using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class Producto
    {
        [Key]
        [Required]
        public int PRD_ID { get; set; }
        [DisplayName("Nombre del producto")]
        [Required]
        public string PRD_NOMBRE { get; set; }
        [Required]
        public string PRD_IMG { get; set; }
        [DisplayName("Descripcion del producto")]
        [Required]
        public string PRD_DESCRIPCION { get; set; }
        [Required]
        public int PRD_CANTIDAD { get; set; }
        [Required]
        public float PRD_PRECIO { get; set; }
        public Producto()
        {
        }
        public Producto(int id, string nombre, string img, string descripcion, int cantidad, float precio)
        {
            PRD_ID = id;
            PRD_NOMBRE = nombre;
            PRD_IMG = img;
            PRD_DESCRIPCION = descripcion;
            PRD_CANTIDAD = cantidad;
            PRD_PRECIO = precio;
        }
    }
}
