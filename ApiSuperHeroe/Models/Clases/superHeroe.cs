using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSuperHeroe.Models.Clases
{
    public class superHeroe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int IdImagenes { get; set; }

        [ForeignKey("IdImagenes")]
        public virtual Imagenes Imagenes { get; set; }
    }
}
