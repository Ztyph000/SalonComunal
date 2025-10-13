using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    // Almacena toda la informacion relevante de los productos para la pagina y su facturacion
    public class TablaPrueba
    {
        [Key]
        [Required]
        public int PRD_ID { get; set; }
        [DisplayName("Nombre del producto")]
        public string PRD_NOMBRE { get; set; }

        public TablaPrueba()
        {
        }
        public TablaPrueba(int id, string nombre)
        {
            PRD_ID = id;
            PRD_NOMBRE = nombre;
        }
    }
}
