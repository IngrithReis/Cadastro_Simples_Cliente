using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteGTI.WebbApi.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataExpedicaoRG = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrgaoExpedicaoRG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SexoCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SexoCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EstadoCivil",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Casado(a)" },
                    { 2, "Solteiro(a)" },
                    { 3, "Viúvo(a)" },
                    { 4, "Divorciado(a)" },
                    { 5, "União Estável" }
                });

            migrationBuilder.InsertData(
                table: "SexoCliente",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Feminino" },
                    { 2, "Masculino" },
                    { 3, "Prefiro não declarar" }
                });

            migrationBuilder.InsertData(
                table: "UFs",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 16, "PR" },
                    { 17, "PE" },
                    { 18, "PI" },
                    { 19, "RJ" },
                    { 20, "RN" },
                    { 24, "SC" },
                    { 22, "RO" },
                    { 23, "RR" },
                    { 15, "PB" },
                    { 25, "SP" },
                    { 21, "RS" },
                    { 14, "PA" },
                    { 10, "MA" },
                    { 12, "MS" },
                    { 11, "MT" },
                    { 26, "SE" },
                    { 9, "GO" },
                    { 8, "ES" },
                    { 7, "DF" },
                    { 6, "CE" },
                    { 5, "BA" },
                    { 4, "AM" },
                    { 3, "AP" },
                    { 2, "AL" },
                    { 1, "AC" },
                    { 13, "MG" },
                    { 27, "TO" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClienteId",
                table: "Endereco",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "SexoCliente");

            migrationBuilder.DropTable(
                name: "UFs");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
