using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    // Almacena toda la informacion relevante de los productos para la pagina y su facturacion
    public class Producto
    {
        [Key]
        [Required]
        public int PRD_ID { get; set; }
        [DisplayName("Nombre del producto")]
        public string PRD_NOMBRE { get; set; }
        public string PRD_IMG { get; set; }
        [DisplayName("Descripcion del producto")]
        public string PRD_DESCRIPCION { get; set; }
        public int PRD_CANTIDAD { get; set; }
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
    // Almacena la informacion importante de cada usuario menos su rol
    public class Usuario
    {
        [Key]
        [Required]
        public int USR_ID { get; set; }
        [DisplayName("Nombre del usuario")]
        public string USR_NOMBRE { get; set; }
        [DisplayName("Contraseña")]
        public string USR_PASS { get; set; }
        [DisplayName("Correo electronico")]
        public string USR_MAIL { get; set; }
        public Usuario()
        {
        }
        public Usuario(int id, string nombre, string pass, string mail)
        {
            USR_ID = id;
            USR_NOMBRE = nombre;
            USR_PASS = pass;
            USR_MAIL = mail;
        }
    }
    // Esta tabla almacena los roles de cada usuario
    public class Roles
    {
        [Key]
        [Required]
        public int ROL_ID { get; set; }
        [DisplayName("Rol del usuario: 0 = admin, 1 = customer")]
        public bool ROL_TIPO { get; set; }
        public int ROL_USR_ID { get; set; }
        public int Usuario { get; set; }
        public Roles()
        {
        }
        public Roles(int id, bool rol, int us_id)
        {
            ROL_ID = id;
            ROL_TIPO = rol;
            ROL_USR_ID = us_id;
        }
    }
    public class Compras
    {
        [Key]
        [Required]
        public int CPS_ID { get; set; }
        [DisplayName("Nombre del producto")]
        public string CPS_FECHA { get; set; }
        public int CPS_USR_ID { get; set; }
        public int Usuario { get; set; }
        public Compras()
        {
        }
        public Compras(int id, string fecha, int us_id)
        {
            CPS_ID = id;
            CPS_FECHA = fecha;
            CPS_USR_ID = us_id;
        }
    }
    public class DETALLE_COMPRAS
    {
        [Key]
        [Required]
        public int DRL_ID { get; set; }
        [DisplayName("Nombre del producto")]
        public int DRL_CANTIDAD { get; set; }
        public float DRL_COSTO { get; set; }
        [DisplayName("Descripcion del producto")]
        public int DRL_PRD_ID { get; set; }
        public int DRL_CPS_ID { get; set; }
        public int Producto { get; set; }
        public int Compras { get; set; }
        public DETALLE_COMPRAS()
        {
        }
        public DETALLE_COMPRAS(int id, int cantidad, float costo, int pr_id, int cp_id)
        {

        }
    }
}
