using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSuperHeroe.Models.Clases
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        [Required]
        public required string clave { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuarios Usuarios { get; set; }
    }
}
