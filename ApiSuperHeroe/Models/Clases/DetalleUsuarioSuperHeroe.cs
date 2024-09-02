using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSuperHeroe.Models.Clases
{
    public class DetalleUsuarioSuperHeroe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdUsuarioSuperHeroe { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuarios Usuarios { get; set; }

        [ForeignKey("IdUsuarioSuperHeroe")]
        public virtual superHeroe SuperHeroe { get; set; }
    }
}
