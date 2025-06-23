using System;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Org.BouncyCastle.Utilities.Zlib;
using VKR_Kontorin.Models;

#nullable disable

namespace VKR_Kontorin.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<string>(type: "text", nullable: true),
                    Tlf = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tlf = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tech_id = table.Column<int>(type: "integer", nullable: false),
                    Tipe_id = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: true),
                    Qty = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Techs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipe_id = table.Column<int>(type: "integer", nullable: false),
                    Brand_id = table.Column<int>(type: "integer", nullable: false),
                    Mark_id = table.Column<int>(type: "integer", nullable: false),
                    Owner_id = table.Column<int>(type: "integer", nullable: false),
                    City_id = table.Column<int>(type: "integer", nullable: false),
                    Distr = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Free = table.Column<bool>(type: "boolean", nullable: false),
                    Cust = table.Column<string>(type: "text", nullable: true),
                    Time = table.Column<string>(type: "text", nullable: true),
                    Block = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Techs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03643505-e8a2-4794-a318-074c4f291c2d", "Admin", "ADMIN" },
                    { "3c91598b-fb2f-4f46-b6cd-ee70a6202130", "User", "USER" },
                    { "e071f020-078f-4d72-97db-9bb44d512221", "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                             "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd",
                             "LockoutEnabled", "AccessFailedCount" },
                values: new object[,]
                {
                    { "363d04f3-db27-4bd0-8ab9-3fcefb38c981", "0000000000", "0000000000", "admin@mail.ru", "ADMIN@MAIL.RU", true, "AQAAAAIAAYagAAAAEO+2pVdareLhzdiuJ7srbZtsv+XILwuCaFdO53gStY/IIEY5o9DWLbVqGJSmk4dgqw==",
                      "KRRBL64KTUCJVVLKTAXSGWLLSS6ZTC3W", "d1e20c83-0c97-4772-ab44-de647f84034f", null, true, false, null,
                      true, 0},
                    { "8462448a-faa8-4f00-9939-0d97f5b682de", "9101111111", "9101111111", "owner@mail.ru", "OWNER@MAIL.RU", true, "AQAAAAIAAYagAAAAEPRsv5qy2Fc8LML9SJ/Lc2dPX1J+w8OTPORNfumBHMTg9c7tNUgMWaiVAF2rQ2JzhQ==",
                      "OI75AL6ZE37JOHZBND553A2MAZQ2YGXD", "00aef1fc-1860-4f25-9d3e-50d0c7879b85", null, true, false, null,
                      true, 0},
                    { "91b5e269-e5ff-4f12-8cfa-4fee7dddd20e", "9152222222", "9152222222", "user@mail.ru", "USER@MAIL.RU", true, "AQAAAAIAAYagAAAAED1i/hUKnIBxfTFCdLt2LlQhkxwGjtg5Kl32xXmtVmJPz0hhDX6piMn9/TQEd/WNdA==",
                      "ARVH3S4AZW3DQTR7G5WMYXJ2VI47OOZC", "a495afeb-522f-408f-86c6-499bb3f7d407", null, false, false, null,
                      true, 0},
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "363d04f3-db27-4bd0-8ab9-3fcefb38c981", "03643505-e8a2-4794-a318-074c4f291c2d" },
                    { "91b5e269-e5ff-4f12-8cfa-4fee7dddd20e", "3c91598b-fb2f-4f46-b6cd-ee70a6202130" },
                    { "8462448a-faa8-4f00-9939-0d97f5b682de", "e071f020-078f-4d72-97db-9bb44d512221" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "CASE" },
                    { "2", "Howo" },
                    { "3", "Ивановец" },
                    { "4", "JCB" },
                    { "5", "Komatsu" },
                    { "6", "МАЗ" },
                    { "7", "Tadano" },
                    { "8", "UNIC" },
                    { "9", "XCMG" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "Ярославль" },
                    { "2", "Ростов" },
                    { "3", "Переславль-Залесский" },
                    { "4", "Тутаев" },
                    { "5", "Рыбинск" },
                    { "6", "Гаврилов-Ям" }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "3CX" },
                    { "2", "4CX" },
                    { "3", "WB93" },
                    { "4", "WB97" },
                    { "5", "XC8" },
                    { "6", "XT8" },
                    { "7", "570X" },
                    { "8", "580V" },
                    { "9", "JS160W" },
                    { "10", "JS200W" },
                    { "11", "PW160" },
                    { "12", "PW200" },
                    { "13", "WX160" },
                    { "14", "WX200" },
                    { "15", "JS200" },
                    { "16", "JS240" },
                    { "17", "PC200" },
                    { "18", "PC240" },
                    { "19", "XE215" },
                    { "20", "XE260" },
                    { "21", "CX210" },
                    { "22", "CX240" },
                    { "23", "65012" },
                    { "24", "65142" },
                    { "25", "HW" },
                    { "26", "TX" },
                    { "27", "SZ" },
                    { "28", "ZR" },
                    { "29", "UR245" },
                    { "30", "UR334" },
                    { "31", "GR800" },
                    { "32", "GR81100" },
                    { "33", "КС35" },
                    { "34", "КС55" },
                    { "35", "XCT25" },
                    { "36", "XCT30" }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Tlf" },
                values: new object[,]
                {
                    { "1", "9101111111" }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "Date", "Qty", "Tech_id", "Tipe_id" },
                values: new object[,]
                {
                    { 1, "01.18", 8, 1, 1 },
                    { 2, "01.18", 5, 2, 1 },
                    { 3, "01.18", 22, 3, 2 },
                    { 4, "01.18", 20, 4, 2 },
                    { 5, "01.18", 0, 5, 3 },
                    { 6, "01.18", 2, 6, 3 },
                    { 7, "01.18", 5, 7, 4 },
                    { 8, "01.18", 2, 8, 4 },
                    { 9, "01.18", 6, 9, 5 },
                    { 10, "01.18", 5, 10, 5 },
                    { 11, "01.18", 6, 11, 6 },
                    { 12, "01.18", 8, 12, 6 },
                    { 13, "02.18", 10, 1, 1 },
                    { 14, "02.18", 7, 2, 1 },
                    { 15, "02.18", 20, 3, 2 },
                    { 16, "02.18", 21, 4, 2 },
                    { 17, "02.18", 4, 5, 3 },
                    { 18, "02.18", 0, 6, 3 },
                    { 19, "02.18", 6, 7, 4 },
                    { 20, "02.18", 2, 8, 4 },
                    { 21, "02.18", 9, 9, 5 },
                    { 22, "02.18", 10, 10, 5 },
                    { 23, "02.18", 8, 11, 6 },
                    { 24, "02.18", 12, 12, 6 },
                    { 25, "03.18", 10, 1, 1 },
                    { 26, "03.18", 10, 2, 1 },
                    { 27, "03.18", 8, 3, 2 },
                    { 28, "03.18", 7, 4, 2 },
                    { 29, "03.18", 2, 5, 3 },
                    { 30, "03.18", 7, 6, 3 },
                    { 31, "03.18", 9, 7, 4 },
                    { 32, "03.18", 9, 8, 4 },
                    { 33, "03.18", 10, 9, 5 },
                    { 34, "03.18", 12, 10, 5 },
                    { 35, "03.18", 6, 11, 6 },
                    { 36, "03.18", 10, 12, 6 },
                    { 37, "04.18", 5, 1, 1 },
                    { 38, "04.18", 3, 2, 1 },
                    { 39, "04.18", 7, 3, 2 },
                    { 40, "04.18", 10, 4, 2 },
                    { 41, "04.18", 0, 5, 3 },
                    { 42, "04.18", 2, 6, 3 },
                    { 43, "04.18", 2, 7, 4 },
                    { 44, "04.18", 2, 8, 4 },
                    { 45, "04.18", 4, 9, 5 },
                    { 46, "04.18", 6, 10, 5 },
                    { 47, "04.18", 7, 11, 6 },
                    { 48, "04.18", 3, 12, 6 },
                    { 49, "05.18", 23, 1, 1 },
                    { 50, "05.18", 12, 2, 1 },
                    { 51, "05.18", 7, 3, 2 },
                    { 52, "05.18", 5, 4, 2 },
                    { 53, "05.18", 7, 5, 3 },
                    { 54, "05.18", 9, 6, 3 },
                    { 55, "05.18", 20, 7, 4 },
                    { 56, "05.18", 22, 8, 4 },
                    { 57, "05.18", 17, 9, 5 },
                    { 58, "05.18", 11, 10, 5 },
                    { 59, "05.18", 25, 11, 6 },
                    { 60, "05.18", 25, 12, 6 },
                    { 61, "06.18", 30, 1, 1 },
                    { 62, "06.18", 26, 2, 1 },
                    { 63, "06.18", 8, 3, 2 },
                    { 64, "06.18", 7, 4, 2 },
                    { 65, "06.18", 25, 5, 3 },
                    { 66, "06.18", 25, 6, 3 },
                    { 67, "06.18", 27, 7, 4 },
                    { 68, "06.18", 26, 8, 4 },
                    { 69, "06.18", 29, 9, 5 },
                    { 70, "06.18", 23, 10, 5 },
                    { 71, "06.18", 28, 11, 6 },
                    { 72, "06.18", 28, 12, 6 },
                    { 73, "07.18", 27, 1, 1 },
                    { 74, "07.18", 28, 2, 1 },
                    { 75, "07.18", 7, 3, 2 },
                    { 76, "07.18", 3, 4, 2 },
                    { 77, "07.18", 25, 5, 3 },
                    { 78, "07.18", 23, 6, 3 },
                    { 79, "07.18", 19, 7, 4 },
                    { 80, "07.18", 17, 8, 4 },
                    { 81, "07.18", 21, 9, 5 },
                    { 82, "07.18", 23, 10, 5 },
                    { 83, "07.18", 29, 11, 6 },
                    { 84, "07.18", 29, 12, 6 },
                    { 85, "08.18", 30, 1, 1 },
                    { 86, "08.18", 20, 2, 1 },
                    { 87, "08.18", 17, 3, 2 },
                    { 88, "08.18", 16, 4, 2 },
                    { 89, "08.18", 19, 5, 3 },
                    { 90, "08.18", 25, 6, 3 },
                    { 91, "08.18", 23, 7, 4 },
                    { 92, "08.18", 23, 8, 4 },
                    { 93, "08.18", 27, 9, 5 },
                    { 94, "08.18", 27, 10, 5 },
                    { 95, "08.18", 29, 11, 6 },
                    { 96, "08.18", 21, 12, 6 },
                    { 97, "09.18", 21, 1, 1 },
                    { 98, "09.18", 23, 2, 1 },
                    { 99, "09.18", 27, 3, 2 },
                    { 100, "09.18", 27, 4, 2 },
                    { 101, "09.18", 16, 5, 3 },
                    { 102, "09.18", 17, 6, 3 },
                    { 103, "09.18", 19, 7, 4 },
                    { 104, "09.18", 17, 8, 4 },
                    { 105, "09.18", 21, 9, 5 },
                    { 106, "09.18", 20, 10, 5 },
                    { 107, "09.18", 25, 11, 6 },
                    { 108, "09.18", 27, 12, 6 },
                    { 109, "10.18", 22, 1, 1 },
                    { 110, "10.18", 17, 2, 1 },
                    { 111, "10.18", 21, 3, 2 },
                    { 112, "10.18", 30, 4, 2 },
                    { 113, "10.18", 17, 5, 3 },
                    { 114, "10.18", 19, 6, 3 },
                    { 115, "10.18", 20, 7, 4 },
                    { 116, "10.18", 9, 8, 4 },
                    { 117, "10.18", 10, 9, 5 },
                    { 118, "10.18", 15, 10, 5 },
                    { 119, "10.18", 12, 11, 6 },
                    { 120, "10.18", 18, 12, 6 },
                    { 121, "11.18", 23, 1, 1 },
                    { 122, "11.18", 5, 2, 1 },
                    { 123, "11.18", 25, 3, 2 },
                    { 124, "11.18", 20, 4, 2 },
                    { 125, "11.18", 20, 5, 3 },
                    { 126, "11.18", 25, 6, 3 },
                    { 127, "11.18", 21, 7, 4 },
                    { 128, "11.18", 27, 8, 4 },
                    { 129, "11.18", 29, 9, 5 },
                    { 130, "11.18", 28, 10, 5 },
                    { 131, "11.18", 26, 11, 6 },
                    { 132, "11.18", 22, 12, 6 },
                    { 133, "12.18", 10, 1, 1 },
                    { 134, "12.18", 10, 2, 1 },
                    { 135, "12.18", 26, 3, 2 },
                    { 136, "12.18", 28, 4, 2 },
                    { 137, "12.18", 0, 5, 3 },
                    { 138, "12.18", 7, 6, 3 },
                    { 139, "12.18", 9, 7, 4 },
                    { 140, "12.18", 3, 8, 4 },
                    { 141, "12.18", 6, 9, 5 },
                    { 142, "12.18", 8, 10, 5 },
                    { 143, "12.18", 5, 11, 6 },
                    { 144, "12.18", 9, 12, 6 },
                    { 145, "01.19", 9, 1, 1 },
                    { 146, "01.19", 9, 2, 1 },
                    { 147, "01.19", 25, 3, 2 },
                    { 148, "01.19", 10, 4, 2 },
                    { 149, "01.19", 0, 5, 3 },
                    { 150, "01.19", 0, 6, 3 },
                    { 151, "01.19", 6, 7, 4 },
                    { 152, "01.19", 6, 8, 4 },
                    { 153, "01.19", 8, 9, 5 },
                    { 154, "01.19", 10, 10, 5 },
                    { 155, "01.19", 7, 11, 6 },
                    { 156, "01.19", 9, 12, 6 },
                    { 157, "02.19", 4, 1, 1 },
                    { 158, "02.19", 6, 2, 1 },
                    { 159, "02.19", 25, 3, 2 },
                    { 160, "02.19", 28, 4, 2 },
                    { 161, "02.19", 3, 5, 3 },
                    { 162, "02.19", 5, 6, 3 },
                    { 163, "02.19", 2, 7, 4 },
                    { 164, "02.19", 8, 8, 4 },
                    { 165, "02.19", 10, 9, 5 },
                    { 166, "02.19", 11, 10, 5 },
                    { 167, "02.19", 11, 11, 6 },
                    { 168, "02.19", 8, 12, 6 },
                    { 169, "03.19", 0, 1, 1 },
                    { 170, "03.19", 7, 2, 1 },
                    { 171, "03.19", 7, 3, 2 },
                    { 172, "03.19", 11, 4, 2 },
                    { 173, "03.19", 3, 5, 3 },
                    { 174, "03.19", 4, 6, 3 },
                    { 175, "03.19", 7, 7, 4 },
                    { 176, "03.19", 3, 8, 4 },
                    { 177, "03.19", 6, 9, 5 },
                    { 178, "03.19", 10, 10, 5 },
                    { 179, "03.19", 5, 11, 6 },
                    { 180, "03.19", 5, 12, 6 },
                    { 181, "04.19", 0, 1, 1 },
                    { 182, "04.19", 6, 2, 1 },
                    { 183, "04.19", 8, 3, 2 },
                    { 184, "04.19", 10, 4, 2 },
                    { 185, "04.19", 0, 5, 3 },
                    { 186, "04.19", 1, 6, 3 },
                    { 187, "04.19", 3, 7, 4 },
                    { 188, "04.19", 4, 8, 4 },
                    { 189, "04.19", 6, 9, 5 },
                    { 190, "04.19", 6, 10, 5 },
                    { 191, "04.19", 4, 11, 6 },
                    { 192, "04.19", 7, 12, 6 },
                    { 193, "05.19", 16, 1, 1 },
                    { 194, "05.19", 15, 2, 1 },
                    { 195, "05.19", 7, 3, 2 },
                    { 196, "05.19", 12, 4, 2 },
                    { 197, "05.19", 17, 5, 3 },
                    { 198, "05.19", 7, 6, 3 },
                    { 199, "05.19", 14, 7, 4 },
                    { 200, "05.19", 21, 8, 4 },
                    { 201, "05.19", 25, 9, 5 },
                    { 202, "05.19", 14, 10, 5 },
                    { 203, "05.19", 18, 11, 6 },
                    { 204, "05.19", 25, 12, 6 },
                    { 205, "06.19", 14, 1, 1 },
                    { 206, "06.19", 26, 2, 1 },
                    { 207, "06.19", 12, 3, 2 },
                    { 208, "06.19", 5, 4, 2 },
                    { 209, "06.19", 20, 5, 3 },
                    { 210, "06.19", 20, 6, 3 },
                    { 211, "06.19", 24, 7, 4 },
                    { 212, "06.19", 25, 8, 4 },
                    { 213, "06.19", 29, 9, 5 },
                    { 214, "06.19", 21, 10, 5 },
                    { 215, "06.19", 29, 11, 6 },
                    { 216, "06.19", 24, 12, 6 },
                    { 217, "07.19", 16, 1, 1 },
                    { 218, "07.19", 27, 2, 1 },
                    { 219, "07.19", 7, 3, 2 },
                    { 220, "07.19", 6, 4, 2 },
                    { 221, "07.19", 23, 5, 3 },
                    { 222, "07.19", 22, 6, 3 },
                    { 223, "07.19", 19, 7, 4 },
                    { 224, "07.19", 24, 8, 4 },
                    { 225, "07.19", 24, 9, 5 },
                    { 226, "07.19", 23, 10, 5 },
                    { 227, "07.19", 20, 11, 6 },
                    { 228, "07.19", 22, 12, 6 },
                    { 229, "08.19", 22, 1, 1 },
                    { 230, "08.19", 20, 2, 1 },
                    { 231, "08.19", 13, 3, 2 },
                    { 232, "08.19", 12, 4, 2 },
                    { 233, "08.19", 18, 5, 3 },
                    { 234, "08.19", 23, 6, 3 },
                    { 235, "08.19", 25, 7, 4 },
                    { 236, "08.19", 22, 8, 4 },
                    { 237, "08.19", 28, 9, 5 },
                    { 238, "08.19", 23, 10, 5 },
                    { 239, "08.19", 29, 11, 6 },
                    { 240, "08.19", 25, 12, 6 },
                    { 241, "09.19", 24, 1, 1 },
                    { 242, "09.19", 27, 2, 1 },
                    { 243, "09.19", 24, 3, 2 },
                    { 244, "09.19", 26, 4, 2 },
                    { 245, "09.19", 22, 5, 3 },
                    { 246, "09.19", 19, 6, 3 },
                    { 247, "09.19", 18, 7, 4 },
                    { 248, "09.19", 24, 8, 4 },
                    { 249, "09.19", 25, 9, 5 },
                    { 250, "09.19", 28, 10, 5 },
                    { 251, "09.19", 28, 11, 6 },
                    { 252, "09.19", 30, 12, 6 },
                    { 253, "10.19", 17, 1, 1 },
                    { 254, "10.19", 12, 2, 1 },
                    { 255, "10.19", 21, 3, 2 },
                    { 256, "10.19", 23, 4, 2 },
                    { 257, "10.19", 9, 5, 3 },
                    { 258, "10.19", 8, 6, 3 },
                    { 259, "10.19", 21, 7, 4 },
                    { 260, "10.19", 15, 8, 4 },
                    { 261, "10.19", 13, 9, 5 },
                    { 262, "10.19", 16, 10, 5 },
                    { 263, "10.19", 12, 11, 6 },
                    { 264, "10.19", 22, 12, 6 },
                    { 265, "11.19", 12, 1, 1 },
                    { 266, "11.19", 9, 2, 1 },
                    { 267, "11.19", 24, 3, 2 },
                    { 268, "11.19", 28, 4, 2 },
                    { 269, "11.19", 20, 5, 3 },
                    { 270, "11.19", 23, 6, 3 },
                    { 271, "11.19", 26, 7, 4 },
                    { 272, "11.19", 25, 8, 4 },
                    { 273, "11.19", 25, 9, 5 },
                    { 274, "11.19", 22, 10, 5 },
                    { 275, "11.19", 23, 11, 6 },
                    { 276, "11.19", 27, 12, 6 },
                    { 277, "12.19", 2, 1, 1 },
                    { 278, "12.19", 6, 2, 1 },
                    { 279, "12.19", 21, 3, 2 },
                    { 280, "12.19", 29, 4, 2 },
                    { 281, "12.19", 2, 5, 3 },
                    { 282, "12.19", 1, 6, 3 },
                    { 283, "12.19", 7, 7, 4 },
                    { 284, "12.19", 7, 8, 4 },
                    { 285, "12.19", 12, 9, 5 },
                    { 286, "12.19", 10, 10, 5 },
                    { 287, "12.19", 9, 11, 6 },
                    { 288, "12.19", 5, 12, 6 },
                    { 289, "01.20", 2, 1, 1 },
                    { 290, "01.20", 5, 2, 1 },
                    { 291, "01.20", 17, 3, 2 },
                    { 292, "01.20", 15, 4, 2 },
                    { 293, "01.20", 0, 5, 3 },
                    { 294, "01.20", 0, 6, 3 },
                    { 295, "01.20", 6, 7, 4 },
                    { 296, "01.20", 3, 8, 4 },
                    { 297, "01.20", 8, 9, 5 },
                    { 298, "01.20", 7, 10, 5 },
                    { 299, "01.20", 8, 11, 6 },
                    { 300, "01.20", 10, 12, 6 },
                    { 301, "02.20", 6, 1, 1 },
                    { 302, "02.20", 7, 2, 1 },
                    { 303, "02.20", 22, 3, 2 },
                    { 304, "02.20", 22, 4, 2 },
                    { 305, "02.20", 5, 5, 3 },
                    { 306, "02.20", 1, 6, 3 },
                    { 307, "02.20", 4, 7, 4 },
                    { 308, "02.20", 9, 8, 4 },
                    { 309, "02.20", 7, 9, 5 },
                    { 310, "02.20", 8, 10, 5 },
                    { 311, "02.20", 11, 11, 6 },
                    { 312, "02.20", 5, 12, 6 },
                    { 313, "03.20", 4, 1, 1 },
                    { 314, "03.20", 12, 2, 1 },
                    { 315, "03.20", 12, 3, 2 },
                    { 316, "03.20", 5, 4, 2 },
                    { 317, "03.20", 4, 5, 3 },
                    { 318, "03.20", 4, 6, 3 },
                    { 319, "03.20", 4, 7, 4 },
                    { 320, "03.20", 2, 8, 4 },
                    { 321, "03.20", 6, 9, 5 },
                    { 322, "03.20", 12, 10, 5 },
                    { 323, "03.20", 11, 11, 6 },
                    { 324, "03.20", 12, 12, 6 },
                    { 325, "04.20", 6, 1, 1 },
                    { 326, "04.20", 7, 2, 1 },
                    { 327, "04.20", 7, 3, 2 },
                    { 328, "04.20", 9, 4, 2 },
                    { 329, "04.20", 0, 5, 3 },
                    { 330, "04.20", 2, 6, 3 },
                    { 331, "04.20", 4, 7, 4 },
                    { 332, "04.20", 0, 8, 4 },
                    { 333, "04.20", 3, 9, 5 },
                    { 334, "04.20", 4, 10, 5 },
                    { 335, "04.20", 3, 11, 6 },
                    { 336, "04.20", 6, 12, 6 },
                    { 337, "05.20", 16, 1, 1 },
                    { 338, "05.20", 24, 2, 1 },
                    { 339, "05.20", 6, 3, 2 },
                    { 340, "05.20", 10, 4, 2 },
                    { 341, "05.20", 7, 5, 3 },
                    { 342, "05.20", 13, 6, 3 },
                    { 343, "05.20", 16, 7, 4 },
                    { 344, "05.20", 8, 8, 4 },
                    { 345, "05.20", 23, 9, 5 },
                    { 346, "05.20", 17, 10, 5 },
                    { 347, "05.20", 18, 11, 6 },
                    { 348, "05.20", 12, 12, 6 },
                    { 349, "06.20", 20, 1, 1 },
                    { 350, "06.20", 25, 2, 1 },
                    { 351, "06.20", 9, 3, 2 },
                    { 352, "06.20", 5, 4, 2 },
                    { 353, "06.20", 19, 5, 3 },
                    { 354, "06.20", 24, 6, 3 },
                    { 355, "06.20", 24, 7, 4 },
                    { 356, "06.20", 21, 8, 4 },
                    { 357, "06.20", 29, 9, 5 },
                    { 358, "06.20", 28, 10, 5 },
                    { 359, "06.20", 27, 11, 6 },
                    { 360, "06.20", 29, 12, 6 },
                    { 361, "07.20", 18, 1, 1 },
                    { 362, "07.20", 28, 2, 1 },
                    { 363, "07.20", 5, 3, 2 },
                    { 364, "07.20", 3, 4, 2 },
                    { 365, "07.20", 15, 5, 3 },
                    { 366, "07.20", 23, 6, 3 },
                    { 367, "07.20", 24, 7, 4 },
                    { 368, "07.20", 23, 8, 4 },
                    { 369, "07.20", 23, 9, 5 },
                    { 370, "07.20", 22, 10, 5 },
                    { 371, "07.20", 27, 11, 6 },
                    { 372, "07.20", 20, 12, 6 },
                    { 373, "08.20", 17, 1, 1 },
                    { 374, "08.20", 27, 2, 1 },
                    { 375, "08.20", 22, 3, 2 },
                    { 376, "08.20", 16, 4, 2 },
                    { 377, "08.20", 16, 5, 3 },
                    { 378, "08.20", 17, 6, 3 },
                    { 379, "08.20", 19, 7, 4 },
                    { 380, "08.20", 22, 8, 4 },
                    { 381, "08.20", 28, 9, 5 },
                    { 382, "08.20", 30, 10, 5 },
                    { 383, "08.20", 28, 11, 6 },
                    { 384, "08.20", 24, 12, 6 },
                    { 385, "09.20", 19, 1, 1 },
                    { 386, "09.20", 30, 2, 1 },
                    { 387, "09.20", 23, 3, 2 },
                    { 388, "09.20", 23, 4, 2 },
                    { 389, "09.20", 25, 5, 3 },
                    { 390, "09.20", 20, 6, 3 },
                    { 391, "09.20", 22, 7, 4 },
                    { 392, "09.20", 25, 8, 4 },
                    { 393, "09.20", 30, 9, 5 },
                    { 394, "09.20", 27, 10, 5 },
                    { 395, "09.20", 25, 11, 6 },
                    { 396, "09.20", 24, 12, 6 },
                    { 397, "10.20", 21, 1, 1 },
                    { 398, "10.20", 14, 2, 1 },
                    { 399, "10.20", 24, 3, 2 },
                    { 400, "10.20", 23, 4, 2 },
                    { 401, "10.20", 18, 5, 3 },
                    { 402, "10.20", 14, 6, 3 },
                    { 403, "10.20", 13, 7, 4 },
                    { 404, "10.20", 13, 8, 4 },
                    { 405, "10.20", 18, 9, 5 },
                    { 406, "10.20", 10, 10, 5 },
                    { 407, "10.20", 25, 11, 6 },
                    { 408, "10.20", 13, 12, 6 },
                    { 409, "11.20", 12, 1, 1 },
                    { 410, "11.20", 5, 2, 1 },
                    { 411, "11.20", 24, 3, 2 },
                    { 412, "11.20", 25, 4, 2 },
                    { 413, "11.20", 16, 5, 3 },
                    { 414, "11.20", 15, 6, 3 },
                    { 415, "11.20", 17, 7, 4 },
                    { 416, "11.20", 23, 8, 4 },
                    { 417, "11.20", 21, 9, 5 },
                    { 418, "11.20", 22, 10, 5 },
                    { 419, "11.20", 30, 11, 6 },
                    { 420, "11.20", 21, 12, 6 },
                    { 421, "12.20", 5, 1, 1 },
                    { 422, "12.20", 7, 2, 1 },
                    { 423, "12.20", 24, 3, 2 },
                    { 424, "12.20", 23, 4, 2 },
                    { 425, "12.20", 5, 5, 3 },
                    { 426, "12.20", 5, 6, 3 },
                    { 427, "12.20", 8, 7, 4 },
                    { 428, "12.20", 2, 8, 4 },
                    { 429, "12.20", 7, 9, 5 },
                    { 430, "12.20", 9, 10, 5 },
                    { 431, "12.20", 6, 11, 6 },
                    { 432, "12.20", 10, 12, 6 },
                    { 433, "01.21", 7, 1, 1 },
                    { 434, "01.21", 9, 2, 1 },
                    { 435, "01.21", 25, 3, 2 },
                    { 436, "01.21", 23, 4, 2 },
                    { 437, "01.21", 4, 5, 3 },
                    { 438, "01.21", 4, 6, 3 },
                    { 439, "01.21", 4, 7, 4 },
                    { 440, "01.21", 2, 8, 4 },
                    { 441, "01.21", 10, 9, 5 },
                    { 442, "01.21", 10, 10, 5 },
                    { 443, "01.21", 10, 11, 6 },
                    { 444, "01.21", 7, 12, 6 },
                    { 445, "02.21", 8, 1, 1 },
                    { 446, "02.21", 10, 2, 1 },
                    { 447, "02.21", 29, 3, 2 },
                    { 448, "02.21", 24, 4, 2 },
                    { 449, "02.21", 4, 5, 3 },
                    { 450, "02.21", 2, 6, 3 },
                    { 451, "02.21", 2, 7, 4 },
                    { 452, "02.21", 7, 8, 4 },
                    { 453, "02.21", 8, 9, 5 },
                    { 454, "02.21", 11, 10, 5 },
                    { 455, "02.21", 10, 11, 6 },
                    { 456, "02.21", 5, 12, 6 },
                    { 457, "03.21", 9, 1, 1 },
                    { 458, "03.21", 11, 2, 1 },
                    { 459, "03.21", 11, 3, 2 },
                    { 460, "03.21", 12, 4, 2 },
                    { 461, "03.21", 1, 5, 3 },
                    { 462, "03.21", 3, 6, 3 },
                    { 463, "03.21", 6, 7, 4 },
                    { 464, "03.21", 4, 8, 4 },
                    { 465, "03.21", 11, 9, 5 },
                    { 466, "03.21", 5, 10, 5 },
                    { 467, "03.21", 12, 11, 6 },
                    { 468, "03.21", 9, 12, 6 },
                    { 469, "04.21", 12, 1, 1 },
                    { 470, "04.21", 4, 2, 1 },
                    { 471, "04.21", 10, 3, 2 },
                    { 472, "04.21", 8, 4, 2 },
                    { 473, "04.21", 0, 5, 3 },
                    { 474, "04.21", 1, 6, 3 },
                    { 475, "04.21", 0, 7, 4 },
                    { 476, "04.21", 1, 8, 4 },
                    { 477, "04.21", 7, 9, 5 },
                    { 478, "04.21", 7, 10, 5 },
                    { 479, "04.21", 3, 11, 6 },
                    { 480, "04.21", 3, 12, 6 },
                    { 481, "05.21", 19, 1, 1 },
                    { 482, "05.21", 23, 2, 1 },
                    { 483, "05.21", 5, 3, 2 },
                    { 484, "05.21", 10, 4, 2 },
                    { 485, "05.21", 8, 5, 3 },
                    { 486, "05.21", 18, 6, 3 },
                    { 487, "05.21", 13, 7, 4 },
                    { 488, "05.21", 9, 8, 4 },
                    { 489, "05.21", 10, 9, 5 },
                    { 490, "05.21", 14, 10, 5 },
                    { 491, "05.21", 13, 11, 6 },
                    { 492, "05.21", 17, 12, 6 },
                    { 493, "06.21", 20, 1, 1 },
                    { 494, "06.21", 20, 2, 1 },
                    { 495, "06.21", 6, 3, 2 },
                    { 496, "06.21", 12, 4, 2 },
                    { 497, "06.21", 16, 5, 3 },
                    { 498, "06.21", 23, 6, 3 },
                    { 499, "06.21", 26, 7, 4 },
                    { 500, "06.21", 19, 8, 4 },
                    { 501, "06.21", 22, 9, 5 },
                    { 502, "06.21", 20, 10, 5 },
                    { 503, "06.21", 26, 11, 6 },
                    { 504, "06.21", 29, 12, 6 },
                    { 505, "07.21", 27, 1, 1 },
                    { 506, "07.21", 20, 2, 1 },
                    { 507, "07.21", 7, 3, 2 },
                    { 508, "07.21", 5, 4, 2 },
                    { 509, "07.21", 23, 5, 3 },
                    { 510, "07.21", 25, 6, 3 },
                    { 511, "07.21", 19, 7, 4 },
                    { 512, "07.21", 22, 8, 4 },
                    { 513, "07.21", 20, 9, 5 },
                    { 514, "07.21", 27, 10, 5 },
                    { 515, "07.21", 29, 11, 6 },
                    { 516, "07.21", 23, 12, 6 },
                    { 517, "08.21", 22, 1, 1 },
                    { 518, "08.21", 21, 2, 1 },
                    { 519, "08.21", 25, 3, 2 },
                    { 520, "08.21", 11, 4, 2 },
                    { 521, "08.21", 15, 5, 3 },
                    { 522, "08.21", 16, 6, 3 },
                    { 523, "08.21", 25, 7, 4 },
                    { 524, "08.21", 25, 8, 4 },
                    { 525, "08.21", 29, 9, 5 },
                    { 526, "08.21", 23, 10, 5 },
                    { 527, "08.21", 28, 11, 6 },
                    { 528, "08.21", 27, 12, 6 },
                    { 529, "09.21", 16, 1, 1 },
                    { 530, "09.21", 21, 2, 1 },
                    { 531, "09.21", 24, 3, 2 },
                    { 532, "09.21", 27, 4, 2 },
                    { 533, "09.21", 21, 5, 3 },
                    { 534, "09.21", 18, 6, 3 },
                    { 535, "09.21", 23, 7, 4 },
                    { 536, "09.21", 18, 8, 4 },
                    { 537, "09.21", 23, 9, 5 },
                    { 538, "09.21", 28, 10, 5 },
                    { 539, "09.21", 22, 11, 6 },
                    { 540, "09.21", 27, 12, 6 },
                    { 541, "10.21", 24, 1, 1 },
                    { 542, "10.21", 25, 2, 1 },
                    { 543, "10.21", 30, 3, 2 },
                    { 544, "10.21", 23, 4, 2 },
                    { 545, "10.21", 6, 5, 3 },
                    { 546, "10.21", 16, 6, 3 },
                    { 547, "10.21", 10, 7, 4 },
                    { 548, "10.21", 14, 8, 4 },
                    { 549, "10.21", 17, 9, 5 },
                    { 550, "10.21", 11, 10, 5 },
                    { 551, "10.21", 22, 11, 6 },
                    { 552, "10.21", 21, 12, 6 },
                    { 553, "11.21", 11, 1, 1 },
                    { 554, "11.21", 10, 2, 1 },
                    { 555, "11.21", 25, 3, 2 },
                    { 556, "11.21", 20, 4, 2 },
                    { 557, "11.21", 18, 5, 3 },
                    { 558, "11.21", 19, 6, 3 },
                    { 559, "11.21", 23, 7, 4 },
                    { 560, "11.21", 26, 8, 4 },
                    { 561, "11.21", 23, 9, 5 },
                    { 562, "11.21", 23, 10, 5 },
                    { 563, "11.21", 20, 11, 6 },
                    { 564, "11.21", 27, 12, 6 },
                    { 565, "12.21", 14, 1, 1 },
                    { 566, "12.21", 6, 2, 1 },
                    { 567, "12.21", 22, 3, 2 },
                    { 568, "12.21", 23, 4, 2 },
                    { 569, "12.21", 0, 5, 3 },
                    { 570, "12.21", 0, 6, 3 },
                    { 571, "12.21", 5, 7, 4 },
                    { 572, "12.21", 2, 8, 4 },
                    { 573, "12.21", 7, 9, 5 },
                    { 574, "12.21", 12, 10, 5 },
                    { 575, "12.21", 8, 11, 6 },
                    { 576, "12.21", 11, 12, 6 },
                    { 577, "01.22", 8, 1, 1 },
                    { 578, "01.22", 8, 2, 1 },
                    { 579, "01.22", 13, 3, 2 },
                    { 580, "01.22", 25, 4, 2 },
                    { 581, "01.22", 5, 5, 3 },
                    { 582, "01.22", 1, 6, 3 },
                    { 583, "01.22", 5, 7, 4 },
                    { 584, "01.22", 4, 8, 4 },
                    { 585, "01.22", 7, 9, 5 },
                    { 586, "01.22", 7, 10, 5 },
                    { 587, "01.22", 7, 11, 6 },
                    { 588, "01.22", 8, 12, 6 },
                    { 589, "02.22", 10, 1, 1 },
                    { 590, "02.22", 10, 2, 1 },
                    { 591, "02.22", 30, 3, 2 },
                    { 592, "02.22", 25, 4, 2 },
                    { 593, "02.22", 6, 5, 3 },
                    { 594, "02.22", 5, 6, 3 },
                    { 595, "02.22", 6, 7, 4 },
                    { 596, "02.22", 3, 8, 4 },
                    { 597, "02.22", 12, 9, 5 },
                    { 598, "02.22", 10, 10, 5 },
                    { 599, "02.22", 10, 11, 6 },
                    { 600, "02.22", 9, 12, 6 },
                    { 601, "03.22", 0, 1, 1 },
                    { 602, "03.22", 10, 2, 1 },
                    { 603, "03.22", 6, 3, 2 },
                    { 604, "03.22", 6, 4, 2 },
                    { 605, "03.22", 2, 5, 3 },
                    { 606, "03.22", 3, 6, 3 },
                    { 607, "03.22", 3, 7, 4 },
                    { 608, "03.22", 7, 8, 4 },
                    { 609, "03.22", 12, 9, 5 },
                    { 610, "03.22", 11, 10, 5 },
                    { 611, "03.22", 8, 11, 6 },
                    { 612, "03.22", 10, 12, 6 },
                    { 613, "04.22", 1, 1, 1 },
                    { 614, "04.22", 5, 2, 1 },
                    { 615, "04.22", 9, 3, 2 },
                    { 616, "04.22", 5, 4, 2 },
                    { 617, "04.22", 0, 5, 3 },
                    { 618, "04.22", 1, 6, 3 },
                    { 619, "04.22", 1, 7, 4 },
                    { 620, "04.22", 4, 8, 4 },
                    { 621, "04.22", 6, 9, 5 },
                    { 622, "04.22", 3, 10, 5 },
                    { 623, "04.22", 7, 11, 6 },
                    { 624, "04.22", 5, 12, 6 },
                    { 625, "05.22", 7, 1, 1 },
                    { 626, "05.22", 14, 2, 1 },
                    { 627, "05.22", 8, 3, 2 },
                    { 628, "05.22", 8, 4, 2 },
                    { 629, "05.22", 17, 5, 3 },
                    { 630, "05.22", 16, 6, 3 },
                    { 631, "05.22", 12, 7, 4 },
                    { 632, "05.22", 19, 8, 4 },
                    { 633, "05.22", 16, 9, 5 },
                    { 634, "05.22", 16, 10, 5 },
                    { 635, "05.22", 13, 11, 6 },
                    { 636, "05.22", 16, 12, 6 },
                    { 637, "06.22", 18, 1, 1 },
                    { 638, "06.22", 29, 2, 1 },
                    { 639, "06.22", 11, 3, 2 },
                    { 640, "06.22", 8, 4, 2 },
                    { 641, "06.22", 17, 5, 3 },
                    { 642, "06.22", 16, 6, 3 },
                    { 643, "06.22", 26, 7, 4 },
                    { 644, "06.22", 19, 8, 4 },
                    { 645, "06.22", 23, 9, 5 },
                    { 646, "06.22", 27, 10, 5 },
                    { 647, "06.22", 25, 11, 6 },
                    { 648, "06.22", 25, 12, 6 },
                    { 649, "07.22", 17, 1, 1 },
                    { 650, "07.22", 22, 2, 1 },
                    { 651, "07.22", 3, 3, 2 },
                    { 652, "07.22", 6, 4, 2 },
                    { 653, "07.22", 25, 5, 3 },
                    { 654, "07.22", 15, 6, 3 },
                    { 655, "07.22", 17, 7, 4 },
                    { 656, "07.22", 17, 8, 4 },
                    { 657, "07.22", 20, 9, 5 },
                    { 658, "07.22", 22, 10, 5 },
                    { 659, "07.22", 26, 11, 6 },
                    { 660, "07.22", 29, 12, 6 },
                    { 661, "08.22", 13, 1, 1 },
                    { 662, "08.22", 27, 2, 1 },
                    { 663, "08.22", 17, 3, 2 },
                    { 664, "08.22", 15, 4, 2 },
                    { 665, "08.22", 15, 5, 3 },
                    { 666, "08.22", 16, 6, 3 },
                    { 667, "08.22", 27, 7, 4 },
                    { 668, "08.22", 22, 8, 4 },
                    { 669, "08.22", 25, 9, 5 },
                    { 670, "08.22", 26, 10, 5 },
                    { 671, "08.22", 27, 11, 6 },
                    { 672, "08.22", 30, 12, 6 },
                    { 673, "09.22", 21, 1, 1 },
                    { 674, "09.22", 24, 2, 1 },
                    { 675, "09.22", 28, 3, 2 },
                    { 676, "09.22", 27, 4, 2 },
                    { 677, "09.22", 21, 5, 3 },
                    { 678, "09.22", 16, 6, 3 },
                    { 679, "09.22", 23, 7, 4 },
                    { 680, "09.22", 22, 8, 4 },
                    { 681, "09.22", 20, 9, 5 },
                    { 682, "09.22", 22, 10, 5 },
                    { 683, "09.22", 20, 11, 6 },
                    { 684, "09.22", 29, 12, 6 },
                    { 685, "10.22", 19, 1, 1 },
                    { 686, "10.22", 25, 2, 1 },
                    { 687, "10.22", 24, 3, 2 },
                    { 688, "10.22", 22, 4, 2 },
                    { 689, "10.22", 17, 5, 3 },
                    { 690, "10.22", 11, 6, 3 },
                    { 691, "10.22", 17, 7, 4 },
                    { 692, "10.22", 13, 8, 4 },
                    { 693, "10.22", 12, 9, 5 },
                    { 694, "10.22", 12, 10, 5 },
                    { 695, "10.22", 12, 11, 6 },
                    { 696, "10.22", 17, 12, 6 },
                    { 697, "11.22", 15, 1, 1 },
                    { 698, "11.22", 10, 2, 1 },
                    { 699, "11.22", 23, 3, 2 },
                    { 700, "11.22", 26, 4, 2 },
                    { 701, "11.22", 21, 5, 3 },
                    { 702, "11.22", 25, 6, 3 },
                    { 703, "11.22", 21, 7, 4 },
                    { 704, "11.22", 25, 8, 4 },
                    { 705, "11.22", 25, 9, 5 },
                    { 706, "11.22", 22, 10, 5 },
                    { 707, "11.22", 20, 11, 6 },
                    { 708, "11.22", 26, 12, 6 },
                    { 709, "12.22", 24, 1, 1 },
                    { 710, "12.22", 7, 2, 1 },
                    { 711, "12.22", 24, 3, 2 },
                    { 712, "12.22", 27, 4, 2 },
                    { 713, "12.22", 2, 5, 3 },
                    { 714, "12.22", 7, 6, 3 },
                    { 715, "12.22", 4, 7, 4 },
                    { 716, "12.22", 2, 8, 4 },
                    { 717, "12.22", 7, 9, 5 },
                    { 718, "12.22", 5, 10, 5 },
                    { 719, "12.22", 5, 11, 6 },
                    { 720, "12.22", 12, 12, 6 },
                    { 721, "01.23", 4, 1, 1 },
                    { 722, "01.23", 10, 2, 1 },
                    { 723, "01.23", 24, 3, 2 },
                    { 724, "01.23", 24, 4, 2 },
                    { 725, "01.23", 3, 5, 3 },
                    { 726, "01.23", 1, 6, 3 },
                    { 727, "01.23", 5, 7, 4 },
                    { 728, "01.23", 2, 8, 4 },
                    { 729, "01.23", 5, 9, 5 },
                    { 730, "01.23", 7, 10, 5 },
                    { 731, "01.23", 7, 11, 6 },
                    { 732, "01.23", 10, 12, 6 },
                    { 733, "02.23", 9, 1, 1 },
                    { 734, "02.23", 11, 2, 1 },
                    { 735, "02.23", 22, 3, 2 },
                    { 736, "02.23", 30, 4, 2 },
                    { 737, "02.23", 1, 5, 3 },
                    { 738, "02.23", 2, 6, 3 },
                    { 739, "02.23", 9, 7, 4 },
                    { 740, "02.23", 7, 8, 4 },
                    { 741, "02.23", 7, 9, 5 },
                    { 742, "02.23", 8, 10, 5 },
                    { 743, "02.23", 8, 11, 6 },
                    { 744, "02.23", 9, 12, 6 },
                    { 745, "03.23", 8, 1, 1 },
                    { 746, "03.23", 9, 2, 1 },
                    { 747, "03.23", 6, 3, 2 },
                    { 748, "03.23", 9, 4, 2 },
                    { 749, "03.23", 1, 5, 3 },
                    { 750, "03.23", 5, 6, 3 },
                    { 751, "03.23", 2, 7, 4 },
                    { 752, "03.23", 2, 8, 4 },
                    { 753, "03.23", 12, 9, 5 },
                    { 754, "03.23", 6, 10, 5 },
                    { 755, "03.23", 5, 11, 6 },
                    { 756, "03.23", 8, 12, 6 },
                    { 757, "04.23", 9, 1, 1 },
                    { 758, "04.23", 3, 2, 1 },
                    { 759, "04.23", 7, 3, 2 },
                    { 760, "04.23", 9, 4, 2 },
                    { 761, "04.23", 0, 5, 3 },
                    { 762, "04.23", 0, 6, 3 },
                    { 763, "04.23", 4, 7, 4 },
                    { 764, "04.23", 1, 8, 4 },
                    { 765, "04.23", 6, 9, 5 },
                    { 766, "04.23", 7, 10, 5 },
                    { 767, "04.23", 4, 11, 6 },
                    { 768, "04.23", 4, 12, 6 },
                    { 769, "05.23", 5, 1, 1 },
                    { 770, "05.23", 24, 2, 1 },
                    { 771, "05.23", 11, 3, 2 },
                    { 772, "05.23", 8, 4, 2 },
                    { 773, "05.23", 13, 5, 3 },
                    { 774, "05.23", 9, 6, 3 },
                    { 775, "05.23", 14, 7, 4 },
                    { 776, "05.23", 15, 8, 4 },
                    { 777, "05.23", 15, 9, 5 },
                    { 778, "05.23", 12, 10, 5 },
                    { 779, "05.23", 24, 11, 6 },
                    { 780, "05.23", 14, 12, 6 },
                    { 781, "06.23", 7, 1, 1 },
                    { 782, "06.23", 22, 2, 1 },
                    { 783, "06.23", 11, 3, 2 },
                    { 784, "06.23", 5, 4, 2 },
                    { 785, "06.23", 15, 5, 3 },
                    { 786, "06.23", 15, 6, 3 },
                    { 787, "06.23", 24, 7, 4 },
                    { 788, "06.23", 26, 8, 4 },
                    { 789, "06.23", 27, 9, 5 },
                    { 790, "06.23", 30, 10, 5 },
                    { 791, "06.23", 30, 11, 6 },
                    { 792, "06.23", 27, 12, 6 },
                    { 793, "07.23", 2, 1, 1 },
                    { 794, "07.23", 24, 2, 1 },
                    { 795, "07.23", 3, 3, 2 },
                    { 796, "07.23", 7, 4, 2 },
                    { 797, "07.23", 22, 5, 3 },
                    { 798, "07.23", 15, 6, 3 },
                    { 799, "07.23", 25, 7, 4 },
                    { 800, "07.23", 25, 8, 4 },
                    { 801, "07.23", 29, 9, 5 },
                    { 802, "07.23", 27, 10, 5 },
                    { 803, "07.23", 21, 11, 6 },
                    { 804, "07.23", 27, 12, 6 },
                    { 805, "08.23", 0, 1, 1 },
                    { 806, "08.23", 24, 2, 1 },
                    { 807, "08.23", 17, 3, 2 },
                    { 808, "08.23", 14, 4, 2 },
                    { 809, "08.23", 15, 5, 3 },
                    { 810, "08.23", 23, 6, 3 },
                    { 811, "08.23", 27, 7, 4 },
                    { 812, "08.23", 22, 8, 4 },
                    { 813, "08.23", 24, 9, 5 },
                    { 814, "08.23", 24, 10, 5 },
                    { 815, "08.23", 20, 11, 6 },
                    { 816, "08.23", 26, 12, 6 },
                    { 817, "09.23", 8, 1, 1 },
                    { 818, "09.23", 25, 2, 1 },
                    { 819, "09.23", 23, 3, 2 },
                    { 820, "09.23", 26, 4, 2 },
                    { 821, "09.23", 19, 5, 3 },
                    { 822, "09.23", 15, 6, 3 },
                    { 823, "09.23", 20, 7, 4 },
                    { 824, "09.23", 26, 8, 4 },
                    { 825, "09.23", 27, 9, 5 },
                    { 826, "09.23", 24, 10, 5 },
                    { 827, "09.23", 25, 11, 6 },
                    { 828, "09.23", 25, 12, 6 },
                    { 829, "10.23", 14, 1, 1 },
                    { 830, "10.23", 25, 2, 1 },
                    { 831, "10.23", 30, 3, 2 },
                    { 832, "10.23", 27, 4, 2 },
                    { 833, "10.23", 15, 5, 3 },
                    { 834, "10.23", 10, 6, 3 },
                    { 835, "10.23", 19, 7, 4 },
                    { 836, "10.23", 9, 8, 4 },
                    { 837, "10.23", 16, 9, 5 },
                    { 838, "10.23", 12, 10, 5 },
                    { 839, "10.23", 23, 11, 6 },
                    { 840, "10.23", 22, 12, 6 },
                    { 841, "11.23", 3, 1, 1 },
                    { 842, "11.23", 11, 2, 1 },
                    { 843, "11.23", 30, 3, 2 },
                    { 844, "11.23", 29, 4, 2 },
                    { 845, "11.23", 15, 5, 3 },
                    { 846, "11.23", 15, 6, 3 },
                    { 847, "11.23", 18, 7, 4 },
                    { 848, "11.23", 25, 8, 4 },
                    { 849, "11.23", 23, 9, 5 },
                    { 850, "11.23", 30, 10, 5 },
                    { 851, "11.23", 20, 11, 6 },
                    { 852, "11.23", 23, 12, 6 },
                    { 853, "12.23", 10, 1, 1 },
                    { 854, "12.23", 8, 2, 1 },
                    { 855, "12.23", 26, 3, 2 },
                    { 856, "12.23", 21, 4, 2 },
                    { 857, "12.23", 7, 5, 3 },
                    { 858, "12.23", 3, 6, 3 },
                    { 859, "12.23", 6, 7, 4 },
                    { 860, "12.23", 9, 8, 4 },
                    { 861, "12.23", 5, 9, 5 },
                    { 862, "12.23", 10, 10, 5 },
                    { 863, "12.23", 7, 11, 6 },
                    { 864, "12.23", 7, 12, 6 },
                    { 865, "01.24", 12, 1, 1 },
                    { 866, "01.24", 10, 2, 1 },
                    { 867, "01.24", 17, 3, 2 },
                    { 868, "01.24", 11, 4, 2 },
                    { 869, "01.24", 5, 5, 3 },
                    { 870, "01.24", 1, 6, 3 },
                    { 871, "01.24", 7, 7, 4 },
                    { 872, "01.24", 4, 8, 4 },
                    { 873, "01.24", 8, 9, 5 },
                    { 874, "01.24", 5, 10, 5 },
                    { 875, "01.24", 7, 11, 6 },
                    { 876, "01.24", 6, 12, 6 },
                    { 877, "02.24", 9, 1, 1 },
                    { 878, "02.24", 10, 2, 1 },
                    { 879, "02.24", 21, 3, 2 },
                    { 880, "02.24", 26, 4, 2 },
                    { 881, "02.24", 5, 5, 3 },
                    { 882, "02.24", 2, 6, 3 },
                    { 883, "02.24", 5, 7, 4 },
                    { 884, "02.24", 8, 8, 4 },
                    { 885, "02.24", 9, 9, 5 },
                    { 886, "02.24", 10, 10, 5 },
                    { 887, "02.24", 11, 11, 6 },
                    { 888, "02.24", 7, 12, 6 },
                    { 889, "03.24", 9, 1, 1 },
                    { 890, "03.24", 10, 2, 1 },
                    { 891, "03.24", 6, 3, 2 },
                    { 892, "03.24", 7, 4, 2 },
                    { 893, "03.24", 6, 5, 3 },
                    { 894, "03.24", 4, 6, 3 },
                    { 895, "03.24", 3, 7, 4 },
                    { 896, "03.24", 6, 8, 4 },
                    { 897, "03.24", 7, 9, 5 },
                    { 898, "03.24", 7, 10, 5 },
                    { 899, "03.24", 10, 11, 6 },
                    { 900, "03.24", 5, 12, 6 },
                    { 901, "04.24", 7, 1, 1 },
                    { 902, "04.24", 5, 2, 1 },
                    { 903, "04.24", 8, 3, 2 },
                    { 904, "04.24", 9, 4, 2 },
                    { 905, "04.24", 2, 5, 3 },
                    { 906, "04.24", 2, 6, 3 },
                    { 907, "04.24", 2, 7, 4 },
                    { 908, "04.24", 0, 8, 4 },
                    { 909, "04.24", 6, 9, 5 },
                    { 910, "04.24", 3, 10, 5 },
                    { 911, "04.24", 3, 11, 6 },
                    { 912, "04.24", 6, 12, 6 },
                    { 913, "05.24", 19, 1, 1 },
                    { 914, "05.24", 22, 2, 1 },
                    { 915, "05.24", 8, 3, 2 },
                    { 916, "05.24", 5, 4, 2 },
                    { 917, "05.24", 8, 5, 3 },
                    { 918, "05.24", 8, 6, 3 },
                    { 919, "05.24", 15, 7, 4 },
                    { 920, "05.24", 16, 8, 4 },
                    { 921, "05.24", 19, 9, 5 },
                    { 922, "05.24", 21, 10, 5 },
                    { 923, "05.24", 19, 11, 6 },
                    { 924, "05.24", 17, 12, 6 },
                    { 925, "06.24", 26, 1, 1 },
                    { 926, "06.24", 25, 2, 1 },
                    { 927, "06.24", 12, 3, 2 },
                    { 928, "06.24", 6, 4, 2 },
                    { 929, "06.24", 20, 5, 3 },
                    { 930, "06.24", 15, 6, 3 },
                    { 931, "06.24", 23, 7, 4 },
                    { 932, "06.24", 22, 8, 4 },
                    { 933, "06.24", 20, 9, 5 },
                    { 934, "06.24", 24, 10, 5 },
                    { 935, "06.24", 22, 11, 6 },
                    { 936, "06.24", 25, 12, 6 },
                    { 937, "07.24", 25, 1, 1 },
                    { 938, "07.24", 21, 2, 1 },
                    { 939, "07.24", 4, 3, 2 },
                    { 940, "07.24", 3, 4, 2 },
                    { 941, "07.24", 20, 5, 3 },
                    { 942, "07.24", 16, 6, 3 },
                    { 943, "07.24", 26, 7, 4 },
                    { 944, "07.24", 23, 8, 4 },
                    { 945, "07.24", 25, 9, 5 },
                    { 946, "07.24", 26, 10, 5 },
                    { 947, "07.24", 25, 11, 6 },
                    { 948, "07.24", 26, 12, 6 },
                    { 949, "08.24", 25, 1, 1 },
                    { 950, "08.24", 30, 2, 1 },
                    { 951, "08.24", 23, 3, 2 },
                    { 952, "08.24", 11, 4, 2 },
                    { 953, "08.24", 15, 5, 3 },
                    { 954, "08.24", 15, 6, 3 },
                    { 955, "08.24", 19, 7, 4 },
                    { 956, "08.24", 24, 8, 4 },
                    { 957, "08.24", 22, 9, 5 },
                    { 958, "08.24", 22, 10, 5 },
                    { 959, "08.24", 25, 11, 6 },
                    { 960, "08.24", 26, 12, 6 },
                    { 961, "09.24", 28, 1, 1 },
                    { 962, "09.24", 20, 2, 1 },
                    { 963, "09.24", 22, 3, 2 },
                    { 964, "09.24", 26, 4, 2 },
                    { 965, "09.24", 20, 5, 3 },
                    { 966, "09.24", 15, 6, 3 },
                    { 967, "09.24", 20, 7, 4 },
                    { 968, "09.24", 24, 8, 4 },
                    { 969, "09.24", 30, 9, 5 },
                    { 970, "09.24", 20, 10, 5 },
                    { 971, "09.24", 25, 11, 6 },
                    { 972, "09.24", 30, 12, 6 },
                    { 973, "10.24", 17, 1, 1 },
                    { 974, "10.24", 19, 2, 1 },
                    { 975, "10.24", 25, 3, 2 },
                    { 976, "10.24", 29, 4, 2 },
                    { 977, "10.24", 19, 5, 3 },
                    { 978, "10.24", 12, 6, 3 },
                    { 979, "10.24", 8, 7, 4 },
                    { 980, "10.24", 22, 8, 4 },
                    { 981, "10.24", 14, 9, 5 },
                    { 982, "10.24", 24, 10, 5 },
                    { 983, "10.24", 21, 11, 6 },
                    { 984, "10.24", 17, 12, 6 },
                    { 985, "11.24", 10, 1, 1 },
                    { 986, "11.24", 10, 2, 1 },
                    { 987, "11.24", 24, 3, 2 },
                    { 988, "11.24", 25, 4, 2 },
                    { 989, "11.24", 16, 5, 3 },
                    { 990, "11.24", 17, 6, 3 },
                    { 991, "11.24", 25, 7, 4 },
                    { 992, "11.24", 19, 8, 4 },
                    { 993, "11.24", 29, 9, 5 },
                    { 994, "11.24", 29, 10, 5 },
                    { 995, "11.24", 23, 11, 6 },
                    { 996, "11.24", 21, 12, 6 },
                    { 997, "12.24", 6, 1, 1 },
                    { 998, "12.24", 8, 2, 1 },
                    { 999, "12.24", 30, 3, 2 },
                    { 1000, "12.24", 20, 4, 2 },
                    { 1001, "12.24", 0, 5, 3 },
                    { 1002, "12.24", 2, 6, 3 },
                    { 1003, "12.24", 6, 7, 4 },
                    { 1004, "12.24", 9, 8, 4 },
                    { 1005, "12.24", 11, 9, 5 },
                    { 1006, "12.24", 7, 10, 5 },
                    { 1007, "12.24", 8, 11, 6 },
                    { 1008, "12.24", 5, 12, 6 },
                });

            migrationBuilder.InsertData(
                table: "Tipes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "экскаватор-погрузчик" },
                    { "2", "колесный экскаватор" },
                    { "3", "гусеничный экскаватор" },
                    { "4", "самосвал" },
                    { "5", "манипулятор" },
                    { "6", "автокран" }
                });

            migrationBuilder.InsertData(
                table: "Techs",
                columns: new[] { "Id", "Tipe_id", "Brand_id", "Mark_id", "Owner_id", "City_id", "Distr", "Price", "Free", "Cust", "Time", "Block" },
                values: new object[,]
                {
                    { 1, 1, 4, 2, 1, 1, "Ленинский", 3000, true, null, null, false },
                    { 2, 1, 5, 4, 1, 1, "Фрунзенский", 3000, false, "9151111111", "13.02.25 07:36", false },
                    { 3, 2, 5, 11, 1, 4, null, 3200, true, null, null, false },
                    { 4, 2, 1, 14, 1, 1, "Ленинский", 3300, true, null, null, false },
                    { 5, 3, 9, 19, 1, 1, "Ленинский", 3500, true, null, null, false },
                    { 6, 3, 5, 17, 1, 1, "Ленинский", 3500, true, null, null, false },
                    { 7, 4, 6, 23, 1, 1, "Фрунзенский", 2500, true, null, null, true },
                    { 8, 4, 2, 25, 1, 1, "Дзержинский", 2500, true, null, null, false },
                    { 9, 5, 7, 28, 1, 1, "Ленинский", 2200, false, "9152222222", "12.02.25 17:25", false },
                    { 10, 5, 8, 29, 1, 1, "Дзержинский", 2400, true, null, null, false },
                    { 11, 6, 3, 33, 1, 1, "Ленинский", 2000, false, "9153333333", "13.02.25 07:18", false },
                    { 12, 6, 7, 31, 1, 1, "Дзержинский", 2500, true, null, null, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
            column: "NormalizedUserName",
                unique: true);

            migrationBuilder.Sql(@"
                -- FUNCTION: public.stat_function()

                -- DROP FUNCTION IF EXISTS public.stat_function();

                CREATE OR REPLACE FUNCTION public.stat_function()
                    RETURNS trigger
                    LANGUAGE 'plpgsql'
                    COST 100
                    VOLATILE NOT LEAKPROOF
                AS $BODY$
                DECLARE
                work_time TIME;
                old_time_time TIME;
                Qty INT;
                date_now_text text;
                BEGIN
	                IF (NEW.""Free"" IS NOT NULL AND NEW.""Free"" <> OLD.""Free"") THEN
		                old_time_time = TO_TIMESTAMP(OLD.""Time"", 'YYYY-MM-DD HH24:MI');
		                work_time := now() - old_time_time;
		                IF (work_time > '05:00:00') THEN
			                date_now_text = to_char(current_timestamp, 'MM.YY');
			                IF EXISTS (SELECT 1 FROM public.""Stats"" WHERE ""Date"" = date_now_text AND ""Tech_id"" = OLD.""Id"") THEN
				                UPDATE public.""Stats"" SET ""Qty"" = ""Qty"" + 1 WHERE ""Date"" = date_now_text AND ""Tech_id"" = OLD.""Id"";
			                ELSE
				                INSERT INTO public.""Stats""(""Tech_id"", ""Date"", ""Qty"", ""Tipe_id"")
				                VALUES(OLD.""Id"", date_now_text, 1, OLD.""Tipe_id"");
			                END IF;
		                END IF;
		                --INSERT INTO public.""Audit""(Tech_id, New_free, Old_time, New_time, Work_time, Qty)
		                --VALUES(OLD.""Id"", NEW.""Free"", OLD.""Time"", now(), Work_time, Qty);
	                END IF;
	                RETURN NEW;
                END 
                $BODY$;

                ALTER FUNCTION public.stat_function()
                    OWNER TO postgres;
            ");

            migrationBuilder.Sql(@"
                CREATE OR REPLACE TRIGGER stat
                AFTER UPDATE 
                ON public.""Techs""
                FOR EACH ROW
                EXECUTE FUNCTION public.stat_function();
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Techs");

            migrationBuilder.DropTable(
                name: "Tipes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
            migrationBuilder.Sql(@"
                DROP TRIGGER IF EXISTS stat ON public.""Techs"";
                DROP FUNCTION IF EXISTS public.stat_function();
            ");
        }
    }
}
