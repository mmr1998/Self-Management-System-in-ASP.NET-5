using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfManagement.Migrations
{
    public partial class addExTypeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExTypeId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExTypeId",
                table: "Expenses",
                column: "ExTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExTypeId",
                table: "Expenses",
                column: "ExTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExTypeId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExTypeId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExTypeId",
                table: "Expenses");
        }
    }
}
