using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entity1.Migrations
{
    /// <inheritdoc />
    public partial class data_ins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clgs",
                columns: new[] { "ClgId", "ClgName" },
                values: new object[,]
                {
                    { new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), "Sunrise Engineering College" },
                    { new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), "OxfordCollege" },
                    { new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"), "Global Science University" },
                    { new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), "Green Valley Institute" },
                    { new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), "National Arts College" }
                });

            migrationBuilder.InsertData(
                table: "Stds",
                columns: new[] { "StdId", "Address", "ClgId", "DOB", "StdDprt", "StdName" },
                values: new object[,]
                {
                    { new Guid("c03bbe45-9aeb-4d24-99e0-4743016ffce9"), "4 Parkside Point", new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSE", "Marguerite" },
                    { new Guid("c3abddbd-cf50-41d2-b6c4-cc7d5a750928"), "6 Morningstar Circle", new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ECE", "Ursa" },
                    { new Guid("c6d50a47-f7e6-4482-8be0-4ddfc057fa6e"), "73 Heath Avenue", new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "MECH", "Franchot" },
                    { new Guid("d1a50a47-f7e6-4482-8be0-4ddfc057fa7b"), "12 Lake View Road", new Guid("22229847-905a-4a0e-9abe-80b61655c5ab"), new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CIVIL", "Anita" },
                    { new Guid("e2b60a47-f7e6-4482-8be0-4ddfc057fa8c"), "89 Green Street", new Guid("33339847-905a-4a0e-9abe-80b61655c5cd"), new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Ravi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clgs",
                keyColumn: "ClgId",
                keyValue: new Guid("12e15727-d369-49a9-8b13-bc22e9362179"));

            migrationBuilder.DeleteData(
                table: "Clgs",
                keyColumn: "ClgId",
                keyValue: new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"));

            migrationBuilder.DeleteData(
                table: "Clgs",
                keyColumn: "ClgId",
                keyValue: new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"));

            migrationBuilder.DeleteData(
                table: "Clgs",
                keyColumn: "ClgId",
                keyValue: new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"));

            migrationBuilder.DeleteData(
                table: "Clgs",
                keyColumn: "ClgId",
                keyValue: new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"));

            migrationBuilder.DeleteData(
                table: "Stds",
                keyColumn: "StdId",
                keyValue: new Guid("c03bbe45-9aeb-4d24-99e0-4743016ffce9"));

            migrationBuilder.DeleteData(
                table: "Stds",
                keyColumn: "StdId",
                keyValue: new Guid("c3abddbd-cf50-41d2-b6c4-cc7d5a750928"));

            migrationBuilder.DeleteData(
                table: "Stds",
                keyColumn: "StdId",
                keyValue: new Guid("c6d50a47-f7e6-4482-8be0-4ddfc057fa6e"));

            migrationBuilder.DeleteData(
                table: "Stds",
                keyColumn: "StdId",
                keyValue: new Guid("d1a50a47-f7e6-4482-8be0-4ddfc057fa7b"));

            migrationBuilder.DeleteData(
                table: "Stds",
                keyColumn: "StdId",
                keyValue: new Guid("e2b60a47-f7e6-4482-8be0-4ddfc057fa8c"));
        }
    }
}
