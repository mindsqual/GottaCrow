using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace GottaCrowWebUI.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Contact_Email_EmailId", table: "Contact");
            migrationBuilder.DropForeignKey(name: "FK_Contact_PhoneNumber_PhoneId", table: "Contact");
            migrationBuilder.DropColumn(name: "EmailId", table: "Contact");
            migrationBuilder.DropColumn(name: "PhoneId", table: "Contact");
            migrationBuilder.DropTable("Email");
            migrationBuilder.DropTable("PhoneNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.Id);
                });
            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Contact",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "Contact",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Email_EmailId",
                table: "Contact",
                column: "EmailId",
                principalTable: "Email",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Contact_PhoneNumber_PhoneId",
                table: "Contact",
                column: "PhoneId",
                principalTable: "PhoneNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
