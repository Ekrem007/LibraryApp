using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAppDal.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookStockTableFx1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer");

            migrationBuilder.AddColumn<int>(
                name: "BookStockId",
                table: "BookTransfer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookTransfer_BookStockId",
                table: "BookTransfer",
                column: "BookStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfer_BookStocks_BookStockId",
                table: "BookTransfer",
                column: "BookStockId",
                principalTable: "BookStocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfer_BookStocks_BookStockId",
                table: "BookTransfer");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer");

            migrationBuilder.DropIndex(
                name: "IX_BookTransfer_BookStockId",
                table: "BookTransfer");

            migrationBuilder.DropColumn(
                name: "BookStockId",
                table: "BookTransfer");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
