using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int USR_ID { get; set; }

        [DisplayName("Nombre completo del usuario")]
        [Required]
        public string USR_NOMBRE { get; set; }

        [DisplayName("Contraseña")]
        [Required]
        public string USR_PASS { get; set; }

        [DisplayName("Correo electronico")]
        [Required]
        public string USR_MAIL { get; set; }
        [Required]
        [Range(0,1, ErrorMessage = "Los valores deben estar en 0 y 1")]
        public int Rol { get; set; }
        public Usuario()
        {
        }
        public Usuario(int id, string nombre, string pass, string mail, int rol)
        {
            USR_ID = id;
            USR_NOMBRE = nombre;
            USR_PASS = pass;
            USR_MAIL = mail;
            Rol = rol;
        }
    }
}
