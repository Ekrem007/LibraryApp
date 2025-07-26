using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAppDal.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookStockTableFx2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer");

            migrationBuilder.DropIndex(
                name: "IX_BookTransfer_BookId",
                table: "BookTransfer");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookTransfer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BookTransfer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookTransfer_BookId",
                table: "BookTransfer",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
