using ApiSuperHeroe.Models.Clases;
using Microsoft.EntityFrameworkCore;

namespace ApiSuperHeroe.Models
{
    public class SuperHeroeContext : DbContext
    {
        public SuperHeroeContext(DbContextOptions<SuperHeroeContext> options) : base(options)
        {
            
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<superHeroe> superHeroes { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<DetalleUsuarioSuperHeroe> DetalleUsuarioSuperHeroes { get; set; }

    }
}
