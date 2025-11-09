using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitasMedicas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCita3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Medico_id_medico",
                table: "Cita");

            migrationBuilder.RenameColumn(
                name: "nombres",
                table: "Paciente",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "fechaNacimiento",
                table: "Paciente",
                newName: "FechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Paciente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "apellidos",
                table: "Paciente",
                newName: "Apellidos");

            migrationBuilder.RenameColumn(
                name: "id_paciente",
                table: "Paciente",
                newName: "IdPaciente");

            migrationBuilder.RenameColumn(
                name: "id_medico",
                table: "Medico",
                newName: "IdMedico");

            migrationBuilder.RenameColumn(
                name: "id_medico",
                table: "Cita",
                newName: "IdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Cita_id_medico",
                table: "Cita",
                newName: "IX_Cita_IdMedico");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Medico_IdMedico",
                table: "Cita",
                column: "IdMedico",
                principalTable: "Medico",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Medico_IdMedico",
                table: "Cita");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Paciente",
                newName: "nombres");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Paciente",
                newName: "fechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Paciente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Paciente",
                newName: "apellidos");

            migrationBuilder.RenameColumn(
                name: "IdPaciente",
                table: "Paciente",
                newName: "id_paciente");

            migrationBuilder.RenameColumn(
                name: "IdMedico",
                table: "Medico",
                newName: "id_medico");

            migrationBuilder.RenameColumn(
                name: "IdMedico",
                table: "Cita",
                newName: "id_medico");

            migrationBuilder.RenameIndex(
                name: "IX_Cita_IdMedico",
                table: "Cita",
                newName: "IX_Cita_id_medico");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Medico_id_medico",
                table: "Cita",
                column: "id_medico",
                principalTable: "Medico",
                principalColumn: "id_medico",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
