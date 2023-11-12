using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UBSDigital.Migrations
{
    public partial class AlteracaoNoCampoNullableEmPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnexosDasConsultas_Consultas_ConsultaId",
                table: "AnexosDasConsultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Pacientes_PacienteId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_UsuariosAmbulatoriais_UsuarioAmbulatorialId",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_PacienteId",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_UsuarioAmbulatorialId",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_AnexosDasConsultas_ConsultaId",
                table: "AnexosDasConsultas");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "UsuarioAmbulatorialId",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "ConsultaId",
                table: "AnexosDasConsultas");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Pacientes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_IdPaciente",
                table: "Consultas",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_IdUsuarioAmbulatorial",
                table: "Consultas",
                column: "IdUsuarioAmbulatorial");

            migrationBuilder.CreateIndex(
                name: "IX_AnexosDasConsultas_IdConsulta",
                table: "AnexosDasConsultas",
                column: "IdConsulta");

            migrationBuilder.AddForeignKey(
                name: "FK_AnexosDasConsultas_Consultas_IdConsulta",
                table: "AnexosDasConsultas",
                column: "IdConsulta",
                principalTable: "Consultas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Pacientes_IdPaciente",
                table: "Consultas",
                column: "IdPaciente",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_UsuariosAmbulatoriais_IdUsuarioAmbulatorial",
                table: "Consultas",
                column: "IdUsuarioAmbulatorial",
                principalTable: "UsuariosAmbulatoriais",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnexosDasConsultas_Consultas_IdConsulta",
                table: "AnexosDasConsultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Pacientes_IdPaciente",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_UsuariosAmbulatoriais_IdUsuarioAmbulatorial",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_IdPaciente",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_IdUsuarioAmbulatorial",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_AnexosDasConsultas_IdConsulta",
                table: "AnexosDasConsultas");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "Complemento",
                keyValue: null,
                column: "Complemento",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Pacientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "PacienteId",
                table: "Consultas",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioAmbulatorialId",
                table: "Consultas",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultaId",
                table: "AnexosDasConsultas",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_PacienteId",
                table: "Consultas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_UsuarioAmbulatorialId",
                table: "Consultas",
                column: "UsuarioAmbulatorialId");

            migrationBuilder.CreateIndex(
                name: "IX_AnexosDasConsultas_ConsultaId",
                table: "AnexosDasConsultas",
                column: "ConsultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnexosDasConsultas_Consultas_ConsultaId",
                table: "AnexosDasConsultas",
                column: "ConsultaId",
                principalTable: "Consultas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Pacientes_PacienteId",
                table: "Consultas",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_UsuariosAmbulatoriais_UsuarioAmbulatorialId",
                table: "Consultas",
                column: "UsuarioAmbulatorialId",
                principalTable: "UsuariosAmbulatoriais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
