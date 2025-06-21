using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VKR_Kontorin.Migrations
{
    /// <inheritdoc />
    public partial class qty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tipe_id",
                table: "Stats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 16, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 29,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 37,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 41,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 42,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 43,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 44,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 49,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 13, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 53,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 54,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 55,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 56,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 61,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 65,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 66,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 67,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 68,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 73,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 77,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 78,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 79,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 80,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 82,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 85,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 86,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 89,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 90,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 91,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 92,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 94,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 97,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 100,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 101,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 102,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 103,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 104,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 105,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 109,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 113,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 114,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 115,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 116,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 18, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 14, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 18, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 121,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 125,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 126,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 127,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 128,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 132,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 133,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 135,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 137,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 138,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 139,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 140,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 145,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 149,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 150,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 151,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 152,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 154,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 157,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 160,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 161,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 162,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 163,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 164,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 165,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 169,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 173,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 174,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 175,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 176,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 181,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 185,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 186,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 187,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 188,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 189,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 190,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 193,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 197,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 198,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 199,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 200,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 205,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 207,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 208,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 209,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 210,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 211,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 212,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 217,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 221,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 222,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 223,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 224,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 229,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 233,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 234,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 235,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 236,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 241,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 245,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 246,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 247,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 248,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 253,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 257,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 258,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 259,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 260,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 265,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 269,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 270,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 271,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 272,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 276,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 277,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 281,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 282,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 283,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 284,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 289,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 293,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 294,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 295,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 296,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 301,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 305,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 306,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 307,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 308,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 313,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 317,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 318,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 319,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 320,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 325,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 329,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 330,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 331,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 332,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 335,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 337,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 340,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 341,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 342,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 343,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 344,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 349,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 353,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 354,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 355,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 356,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 361,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 365,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 366,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 367,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 368,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 370,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 373,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 13, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 376,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 377,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 378,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 379,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 380,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 385,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 389,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 390,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 391,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 392,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 397,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 401,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 402,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 403,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 404,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 13, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 409,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 411,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 413,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 414,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 415,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 416,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 421,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 422,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 425,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 426,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 427,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 428,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 433,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 437,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 438,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 439,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 440,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 441,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 442,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 445,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 449,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 450,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 451,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 452,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 457,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 461,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 462,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 463,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 464,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 469,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 470,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 473,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 474,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 475,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 476,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 481,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 485,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 486,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 487,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 488,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 493,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 496,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 497,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 498,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 499,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 500,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 505,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 506,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 509,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 510,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 511,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 512,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 517,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 14, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 521,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 522,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 523,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 524,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 525,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 529,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 531,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 533,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 534,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 535,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 536,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 541,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 543,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 545,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 546,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 547,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 548,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 553,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 555,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 557,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 558,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 559,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 560,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 565,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 569,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 570,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 571,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 572,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 577,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 581,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 582,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 583,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 584,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 585,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 589,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 593,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 594,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 595,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 596,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 597,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 600,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 601,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 605,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 606,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 607,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 608,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 613,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 617,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 618,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 619,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 620,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 621,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 623,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 625,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 629,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 630,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 631,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 632,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 13, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 637,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 641,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 642,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 643,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 644,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 646,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 649,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 650,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 653,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 654,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 655,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 656,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 661,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 14, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 665,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 666,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 667,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 668,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 670,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 673,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 677,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 678,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 679,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 680,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 682,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 685,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 15, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 689,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 690,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 691,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 692,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 697,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 701,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 702,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 703,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 704,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 709,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 713,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 714,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 715,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 716,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 717,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 721,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 725,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 726,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 727,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 728,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 733,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 735,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 737,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 738,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 739,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 740,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 741,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 745,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 746,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 749,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 750,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 751,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 752,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 757,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 761,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 762,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 763,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 764,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 769,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 773,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 774,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 775,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 776,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 780,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 781,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 783,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 785,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 786,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 787,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 788,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 793,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 795,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 797,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 798,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 799,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 800,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 805,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 809,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 810,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 811,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 812,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 815,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 817,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 821,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 822,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 823,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 824,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 829,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 833,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 834,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 835,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 836,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 14, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 16, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 841,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 845,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 846,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 847,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 848,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 853,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 857,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 858,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 859,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 860,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 861,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 864,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 865,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 869,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 870,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 871,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 872,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 881,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 882,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 883,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 884,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 885,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 889,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 890,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 892,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 893,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 894,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 895,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 896,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 899,
                column: "Tipe_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 905,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 906,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 907,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 908,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 910,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 16, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 917,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 918,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 919,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 920,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 18, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 14, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 929,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 930,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 931,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 932,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 29, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 939,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 941,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 942,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 943,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 944,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 952,
                column: "Tipe_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 953,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 954,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 955,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 956,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 28, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 965,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 966,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 967,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 968,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 25, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 27, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 21, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 977,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 978,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 979,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 980,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 19, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 982,
                column: "Tipe_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 17, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 14, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 986,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 22, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 989,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 990,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 991,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 992,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 30, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 997,
                column: "Tipe_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 26, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 23, 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Tipe_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1003,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1004,
                column: "Tipe_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Qty", "Tipe_id" },
                values: new object[] { 9, 6 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipe_id",
                table: "Stats");

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 36,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 38,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 39,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 40,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 45,
                column: "Qty",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 46,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 47,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 48,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 50,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 51,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 52,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 57,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 58,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 59,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 60,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 62,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 63,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 64,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 69,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 70,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 71,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 72,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 74,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 75,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 76,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 81,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 83,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 84,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 87,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 88,
                column: "Qty",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 93,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 95,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 96,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 98,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 99,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 106,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 107,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 108,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 110,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 111,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 112,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 117,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 118,
                column: "Qty",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 119,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 120,
                column: "Qty",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 122,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 123,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 124,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 129,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 130,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 131,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 134,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 136,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 141,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 142,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 143,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 144,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 146,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 147,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 148,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 153,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 155,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 156,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 158,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 159,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 166,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 167,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 168,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 170,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 171,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 172,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 177,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 178,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 179,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 180,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 182,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 183,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 184,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 191,
                column: "Qty",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 192,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 194,
                column: "Qty",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 195,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 196,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 201,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 202,
                column: "Qty",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 203,
                column: "Qty",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 204,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 206,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 213,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 214,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 215,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 216,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 218,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 219,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 220,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 225,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 226,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 227,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 228,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 230,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 231,
                column: "Qty",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 232,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 237,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 238,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 239,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 240,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 242,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 243,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 244,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 249,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 250,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 251,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 252,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 254,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 255,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 256,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 261,
                column: "Qty",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 262,
                column: "Qty",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 263,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 264,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 266,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 267,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 268,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 273,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 274,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 275,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 278,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 279,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 280,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 285,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 286,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 287,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 288,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 290,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 291,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 292,
                column: "Qty",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 297,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 298,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 299,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 300,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 302,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 303,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 304,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 309,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 310,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 311,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 312,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 314,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 315,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 316,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 321,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 322,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 323,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 324,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 326,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 327,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 328,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 333,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 334,
                column: "Qty",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 336,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 338,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 339,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 345,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 346,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 347,
                column: "Qty",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 348,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 350,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 351,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 352,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 357,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 358,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 359,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 360,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 362,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 363,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 364,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 369,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 371,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 372,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 374,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 375,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 381,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 382,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 383,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 384,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 386,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 387,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 388,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 393,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 394,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 395,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 396,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 398,
                column: "Qty",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 399,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 400,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 405,
                column: "Qty",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 406,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 407,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 408,
                column: "Qty",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 410,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 412,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 417,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 418,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 419,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 420,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 423,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 424,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 429,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 430,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 431,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 432,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 434,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 435,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 436,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 443,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 444,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 446,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 447,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 448,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 453,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 454,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 455,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 456,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 458,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 459,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 460,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 465,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 466,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 467,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 468,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 471,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 472,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 477,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 478,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 479,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 480,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 482,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 483,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 484,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 489,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 490,
                column: "Qty",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 491,
                column: "Qty",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 492,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 494,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 495,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 501,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 502,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 503,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 504,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 507,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 508,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 513,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 514,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 515,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 516,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 518,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 519,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 520,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 526,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 527,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 528,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 530,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 532,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 537,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 538,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 539,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 540,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 542,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 544,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 549,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 550,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 551,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 552,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 554,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 556,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 561,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 562,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 563,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 564,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 566,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 567,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 568,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 573,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 574,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 575,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 576,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 578,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 579,
                column: "Qty",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 580,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 586,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 587,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 588,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 590,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 591,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 592,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 598,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 599,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 602,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 603,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 604,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 609,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 610,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 611,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 612,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 614,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 615,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 616,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 622,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 624,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 626,
                column: "Qty",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 627,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 628,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 633,
                column: "Qty",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 634,
                column: "Qty",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 635,
                column: "Qty",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 636,
                column: "Qty",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 638,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 639,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 640,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 645,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 647,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 648,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 651,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 652,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 657,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 658,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 659,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 660,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 662,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 663,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 664,
                column: "Qty",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 669,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 671,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 672,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 674,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 675,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 676,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 681,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 683,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 684,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 686,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 687,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 688,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 693,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 694,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 695,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 696,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 698,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 699,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 700,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 705,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 706,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 707,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 708,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 710,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 711,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 712,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 718,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 719,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 720,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 722,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 723,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 724,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 729,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 730,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 731,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 732,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 734,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 736,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 742,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 743,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 744,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 747,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 748,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 753,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 754,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 755,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 756,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 758,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 759,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 760,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 765,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 766,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 767,
                column: "Qty",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 768,
                column: "Qty",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 770,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 771,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 772,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 777,
                column: "Qty",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 778,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 779,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 782,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 784,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 789,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 790,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 791,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 792,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 794,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 796,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 801,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 802,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 803,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 804,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 806,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 807,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 808,
                column: "Qty",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 813,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 814,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 816,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 818,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 819,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 820,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 825,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 826,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 827,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 828,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 830,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 831,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 832,
                column: "Qty",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 837,
                column: "Qty",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 838,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 839,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 840,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 842,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 843,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 844,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 849,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 850,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 851,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 852,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 854,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 855,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 856,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 862,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 863,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 866,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 867,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 868,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 873,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 874,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 875,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 876,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 877,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 878,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 879,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 880,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 886,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 887,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 888,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 891,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 897,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 898,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 900,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 901,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 902,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 903,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 904,
                column: "Qty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 909,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 911,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 912,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 913,
                column: "Qty",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 914,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 915,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 916,
                column: "Qty",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 921,
                column: "Qty",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 922,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 923,
                column: "Qty",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 924,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 925,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 926,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 927,
                column: "Qty",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 928,
                column: "Qty",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 933,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 934,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 935,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 936,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 937,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 938,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 940,
                column: "Qty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 945,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 946,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 947,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 948,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 949,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 950,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 951,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 957,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 958,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 959,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 960,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 961,
                column: "Qty",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 962,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 963,
                column: "Qty",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 964,
                column: "Qty",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 969,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 970,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 971,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 972,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 973,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 974,
                column: "Qty",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 975,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 976,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 981,
                column: "Qty",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 983,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 984,
                column: "Qty",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 985,
                column: "Qty",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 987,
                column: "Qty",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 988,
                column: "Qty",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 993,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 994,
                column: "Qty",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 995,
                column: "Qty",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 996,
                column: "Qty",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 998,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 999,
                column: "Qty",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Qty",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1005,
                column: "Qty",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1006,
                column: "Qty",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1007,
                column: "Qty",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1008,
                column: "Qty",
                value: 5);
        }
    }
}
