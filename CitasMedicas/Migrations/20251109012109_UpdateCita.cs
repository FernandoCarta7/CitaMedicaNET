using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitasMedicas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_medico",
                table: "Cita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cita_id_medico",
                table: "Cita",
                column: "id_medico");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Medico_id_medico",
                table: "Cita",
                column: "id_medico",
                principalTable: "Medico",
                principalColumn: "id_medico",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Medico_id_medico",
                table: "Cita");

            migrationBuilder.DropIndex(
                name: "IX_Cita_id_medico",
                table: "Cita");

            migrationBuilder.DropColumn(
                name: "id_medico",
                table: "Cita");
        }
    }
}
