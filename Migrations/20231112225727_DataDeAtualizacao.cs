using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UBSDigital.Migrations
{
    public partial class DataDeAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeAtualizacao",
                table: "Consultas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDeAtualizacao",
                table: "Consultas");
        }
    }
}
