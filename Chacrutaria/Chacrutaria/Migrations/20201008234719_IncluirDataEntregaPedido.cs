using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chacrutaria.Migrations
{
    public partial class IncluirDataEntregaPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DtaPedidoEntregueEm",
                table: "Pedidos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtaPedidoEntregueEm",
                table: "Pedidos");
        }
    }
}
