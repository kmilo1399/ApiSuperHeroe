using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSuperHeroe.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ruta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tamano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Generos_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "superHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdImagenes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superHeroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_superHeroes_Imagenes_IdImagenes",
                        column: x => x.IdImagenes,
                        principalTable: "Imagenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Login_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleUsuarioSuperHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioSuperHeroe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleUsuarioSuperHeroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleUsuarioSuperHeroes_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleUsuarioSuperHeroes_superHeroes_IdUsuarioSuperHeroe",
                        column: x => x.IdUsuarioSuperHeroe,
                        principalTable: "superHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleUsuarioSuperHeroes_IdUsuario",
                table: "DetalleUsuarioSuperHeroes",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleUsuarioSuperHeroes_IdUsuarioSuperHeroe",
                table: "DetalleUsuarioSuperHeroes",
                column: "IdUsuarioSuperHeroe");

            migrationBuilder.CreateIndex(
                name: "IX_Login_IdUsuario",
                table: "Login",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_superHeroes_IdImagenes",
                table: "superHeroes",
                column: "IdImagenes");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdGenero",
                table: "Usuarios",
                column: "IdGenero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleUsuarioSuperHeroes");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "superHeroes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Imagenes");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
