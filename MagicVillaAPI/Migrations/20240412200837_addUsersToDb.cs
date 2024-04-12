using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 8, 37, 825, DateTimeKind.Local).AddTicks(5010), "https://dotnetmastery.com/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 8, 37, 825, DateTimeKind.Local).AddTicks(5040), "https://dotnetmastery.com/bluevillaimages/villa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 8, 37, 825, DateTimeKind.Local).AddTicks(5050), "https://dotnetmastery.com/bluevillaimages/villa4.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 8, 37, 825, DateTimeKind.Local).AddTicks(5050), "https://dotnetmastery.com/bluevillaimages/villa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 8, 37, 825, DateTimeKind.Local).AddTicks(5050), "https://dotnetmastery.com/bluevillaimages/villa2.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 43, 29, 753, DateTimeKind.Local).AddTicks(3780), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 43, 29, 753, DateTimeKind.Local).AddTicks(3830), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 43, 29, 753, DateTimeKind.Local).AddTicks(3830), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 43, 29, 753, DateTimeKind.Local).AddTicks(3830), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 43, 29, 753, DateTimeKind.Local).AddTicks(3840), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg" });
        }
    }
}
