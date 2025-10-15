using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class Rol
    {
        [Key]
        [Required]
        public int ROL_ID { get; set; }
        [DisplayName("Rol del usuario: 0 = admin, 1 = customer")]
        [Required]
        public bool ROL_TIPO { get; set; }
        public Rol()
        {
        }
        public Rol(int id, bool rol, int us)
        {
            ROL_ID = id;
            ROL_TIPO = rol;
        }
    }
}
