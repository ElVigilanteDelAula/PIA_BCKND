using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiConsultasMedicas.Migrations
{
    /// <inheritdoc />
    public partial class DetallesPaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diagnostico",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "Receta",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "Sintomas",
                table: "Consulta");

            migrationBuilder.CreateTable(
                name: "DetallesPaciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Enfermedades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPaciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesPaciente_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesPaciente_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPaciente_MedicoId",
                table: "DetallesPaciente",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPaciente_PacienteId",
                table: "DetallesPaciente",
                column: "PacienteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesPaciente");

            migrationBuilder.AddColumn<string>(
                name: "Diagnostico",
                table: "Consulta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Receta",
                table: "Consulta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sintomas",
                table: "Consulta",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
