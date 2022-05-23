using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace sistemaGerenciamentoAssistenciaTecnica.Migrations
{
    public partial class AdicionandoRelacionamentoordemdeservicocomstatusordemdeservico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_EquipamentosClientes_EquipamentoClienteId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_Tecnicos_TecnicoId",
                table: "OrdemServico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdemServico",
                table: "OrdemServico");

            migrationBuilder.RenameTable(
                name: "OrdemServico",
                newName: "OrdemServicos");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_TecnicoId",
                table: "OrdemServicos",
                newName: "IX_OrdemServicos_TecnicoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_EquipamentoClienteId",
                table: "OrdemServicos",
                newName: "IX_OrdemServicos_EquipamentoClienteId");

            migrationBuilder.AddColumn<int>(
                name: "IdStatusOrdemServico",
                table: "OrdemServicos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdemServicos",
                table: "OrdemServicos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "StatusOrdems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Inicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    Fim = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusOrdems", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServicos_IdStatusOrdemServico",
                table: "OrdemServicos",
                column: "IdStatusOrdemServico",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServicos_EquipamentosClientes_EquipamentoClienteId",
                table: "OrdemServicos",
                column: "EquipamentoClienteId",
                principalTable: "EquipamentosClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServicos_StatusOrdems_IdStatusOrdemServico",
                table: "OrdemServicos",
                column: "IdStatusOrdemServico",
                principalTable: "StatusOrdems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServicos_Tecnicos_TecnicoId",
                table: "OrdemServicos",
                column: "TecnicoId",
                principalTable: "Tecnicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServicos_EquipamentosClientes_EquipamentoClienteId",
                table: "OrdemServicos");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServicos_StatusOrdems_IdStatusOrdemServico",
                table: "OrdemServicos");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServicos_Tecnicos_TecnicoId",
                table: "OrdemServicos");

            migrationBuilder.DropTable(
                name: "StatusOrdems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdemServicos",
                table: "OrdemServicos");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServicos_IdStatusOrdemServico",
                table: "OrdemServicos");

            migrationBuilder.DropColumn(
                name: "IdStatusOrdemServico",
                table: "OrdemServicos");

            migrationBuilder.RenameTable(
                name: "OrdemServicos",
                newName: "OrdemServico");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServicos_TecnicoId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_TecnicoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServicos_EquipamentoClienteId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_EquipamentoClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdemServico",
                table: "OrdemServico",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_EquipamentosClientes_EquipamentoClienteId",
                table: "OrdemServico",
                column: "EquipamentoClienteId",
                principalTable: "EquipamentosClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_Tecnicos_TecnicoId",
                table: "OrdemServico",
                column: "TecnicoId",
                principalTable: "Tecnicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
