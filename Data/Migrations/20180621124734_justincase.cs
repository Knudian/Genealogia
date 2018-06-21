using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Genealogia.Data.Migrations
{
    public partial class justincase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(char));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "gender",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
