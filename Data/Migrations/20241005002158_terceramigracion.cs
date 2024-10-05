using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace parcial_antaurco.Data.Migrations
{
    /// <inheritdoc />
    public partial class terceramigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Remesas",
                table: "Remesas");

            migrationBuilder.RenameTable(
                name: "Remesas",
                newName: "Remesa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Remesa",
                table: "Remesa",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Conversion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MontoOriginal = table.Column<decimal>(type: "numeric", nullable: false),
                    MonedaOriginal = table.Column<string>(type: "text", nullable: true),
                    MontoConvertido = table.Column<decimal>(type: "numeric", nullable: false),
                    MonedaConvertida = table.Column<string>(type: "text", nullable: true),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversion", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Remesa",
                table: "Remesa");

            migrationBuilder.RenameTable(
                name: "Remesa",
                newName: "Remesas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Remesas",
                table: "Remesas",
                column: "Id");
        }
    }
}
