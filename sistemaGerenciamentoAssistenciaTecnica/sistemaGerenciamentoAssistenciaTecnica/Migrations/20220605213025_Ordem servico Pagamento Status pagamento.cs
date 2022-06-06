using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace sistemaGerenciamentoAssistenciaTecnica.Migrations
{
    public partial class OrdemservicoPagamentoStatuspagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "StatusOrdems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OrdemServicos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(247)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateTable(
                name: "StatusPagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DataPagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPagamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TipoDoPagamento = table.Column<string>(type: "text", nullable: true),
                    ValorDoServico = table.Column<double>(type: "double", nullable: false),
                    IdStatusPagamento = table.Column<int>(type: "int", nullable: true),
                    IdOrdemServico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_OrdemServicos_IdOrdemServico",
                        column: x => x.IdOrdemServico,
                        principalTable: "OrdemServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagamentos_StatusPagamentos_IdStatusPagamento",
                        column: x => x.IdStatusPagamento,
                        principalTable: "StatusPagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_IdOrdemServico",
                table: "Pagamentos",
                column: "IdOrdemServico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_IdStatusPagamento",
                table: "Pagamentos",
                column: "IdStatusPagamento",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "StatusPagamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "StatusOrdems",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OrdemServicos",
                type: "varchar(247)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);
        }
    }
}
