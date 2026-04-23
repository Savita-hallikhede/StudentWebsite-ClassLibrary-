using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity1.Migrations
{
    /// <inheritdoc />
    public partial class insert_tab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clgs",
                columns: table => new
                {
                    ClgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClgName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clgs", x => x.ClgId);
                });

            migrationBuilder.CreateTable(
                name: "Stds",
                columns: table => new
                {
                    StdId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StdDprt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stds", x => x.StdId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clgs");

            migrationBuilder.DropTable(
                name: "Stds");
        }
    }
}
