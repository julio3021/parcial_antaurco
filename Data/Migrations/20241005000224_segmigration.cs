using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace parcial_antaurco.Data.Migrations
{
    /// <inheritdoc />
    public partial class segmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Remesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreRemitente = table.Column<string>(type: "text", nullable: true),
                    NombreDestinatario = table.Column<string>(type: "text", nullable: true),
                    PaisOrigen = table.Column<string>(type: "text", nullable: true),
                    PaisDestino = table.Column<string>(type: "text", nullable: true),
                    MontoEnviado = table.Column<decimal>(type: "numeric", nullable: false),
                    Moneda = table.Column<string>(type: "text", nullable: true),
                    TasaDeCambio = table.Column<decimal>(type: "numeric", nullable: false),
                    MontoFinal = table.Column<decimal>(type: "numeric", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remesas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Remesas");
        }
    }
}
