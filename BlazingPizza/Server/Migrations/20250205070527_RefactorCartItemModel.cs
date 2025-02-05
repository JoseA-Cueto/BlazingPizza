using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingPizza.Server.Migrations
{
    /// <inheritdoc />
    public partial class RefactorCartItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Pizzas_PizzaId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_PizzaId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "PizzaName",
                table: "CartItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PizzaName",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_PizzaId",
                table: "CartItems",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Pizzas_PizzaId",
                table: "CartItems",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
