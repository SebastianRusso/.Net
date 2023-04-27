using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAppBackend.Migrations
{
    /// <inheritdoc />
    public partial class CreateCursotable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameLastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DescripcionCorta = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DescripcionLarga = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    PublicoObjetivo = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Objetivos = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Requisitos = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
