using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DNI = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Celular = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CalificacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Calificacion_CalificacionId",
                        column: x => x.CalificacionId,
                        principalTable: "Calificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Calificacion",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Muy Bueno" },
                    { 2, "Bueno" },
                    { 3, "Regular" },
                    { 4, "No Recomendado" }
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Miembro" },
                    { 3, "Refugio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CalificacionId",
                table: "Usuario",
                column: "CalificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolId",
                table: "Usuario",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Calificacion");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
