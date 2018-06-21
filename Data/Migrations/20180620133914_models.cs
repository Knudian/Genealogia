using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Genealogia.Data.Migrations
{
    public partial class models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dynasties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dynasties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Country = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    DateOfDeath = table.Column<DateTime>(nullable: true),
                    DynastyId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PlaceOfBirthId = table.Column<int>(nullable: true),
                    PlaceOfDeathId = table.Column<int>(nullable: true),
                    gender = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Dynasties_DynastyId",
                        column: x => x.DynastyId,
                        principalTable: "Dynasties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Places_PlaceOfBirthId",
                        column: x => x.PlaceOfBirthId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Places_PlaceOfDeathId",
                        column: x => x.PlaceOfDeathId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reigns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AreaId = table.Column<int>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reigns_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reigns_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DynastyId",
                table: "Persons",
                column: "DynastyId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PlaceOfBirthId",
                table: "Persons",
                column: "PlaceOfBirthId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PlaceOfDeathId",
                table: "Persons",
                column: "PlaceOfDeathId");

            migrationBuilder.CreateIndex(
                name: "IX_Reigns_AreaId",
                table: "Reigns",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reigns_PersonId",
                table: "Reigns",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reigns");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Dynasties");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
