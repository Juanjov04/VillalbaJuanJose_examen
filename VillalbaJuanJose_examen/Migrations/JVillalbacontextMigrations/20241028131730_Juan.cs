﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillalbaJuanJose_examen.Migrations.JVillalbacontextMigrations
{
    /// <inheritdoc />
    public partial class Juan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JVillalba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peso = table.Column<float>(type: "real", nullable: false),
                    genero = table.Column<bool>(type: "bit", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JVillalba", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JVillalba");
        }
    }
}