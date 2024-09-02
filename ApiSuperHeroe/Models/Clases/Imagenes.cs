using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSuperHeroe.Models.Clases
{
    public class Imagenes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public required string Nombre { get; set; }
        [Required]
        public required string Ruta { get; set; }
        public int tamano { get; set; }
    }
}
