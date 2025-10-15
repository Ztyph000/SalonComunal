using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prog5_3C2025.Migrations
{
    /// <inheritdoc />
    public partial class cosa12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CPS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPS_FECHA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CPS_ID);
                });

            migrationBuilder.CreateTable(
                name: "Detalles_compras",
                columns: table => new
                {
                    DRL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DRL_CANTIDAD = table.Column<int>(type: "int", nullable: false),
                    DRL_COSTO = table.Column<float>(type: "real", nullable: false),
                    Producto = table.Column<int>(type: "int", nullable: false),
                    Compras = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles_compras", x => x.DRL_ID);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    PRD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRD_NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRD_IMG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRD_DESCRIPCION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRD_CANTIDAD = table.Column<int>(type: "int", nullable: false),
                    PRD_PRECIO = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.PRD_ID);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    ROL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROL_TIPO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.ROL_ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    USR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USR_NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_PASS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_MAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.USR_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Detalles_compras");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
