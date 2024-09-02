using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSuperHeroe.Models.Clases
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Telefono { get; set; }
        public int IdGenero { get; set; }

        [ForeignKey("IdGenero")]
        public virtual Genero genero { get; set; }
    }
}
