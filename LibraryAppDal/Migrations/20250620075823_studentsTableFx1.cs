using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAppDal.Migrations
{
    /// <inheritdoc />
    public partial class studentsTableFx1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfer_Students_StudentId",
                table: "BookTransfer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTransfer",
                table: "BookTransfer");

            migrationBuilder.RenameTable(
                name: "BookTransfer",
                newName: "BookTransfers");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransfer_StudentId",
                table: "BookTransfers",
                newName: "IX_BookTransfers_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransfer_BookId",
                table: "BookTransfers",
                newName: "IX_BookTransfers_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTransfers",
                table: "BookTransfers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfers_Books_BookId",
                table: "BookTransfers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfers_Students_StudentId",
                table: "BookTransfers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfers_Books_BookId",
                table: "BookTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransfers_Students_StudentId",
                table: "BookTransfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTransfers",
                table: "BookTransfers");

            migrationBuilder.RenameTable(
                name: "BookTransfers",
                newName: "BookTransfer");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransfers_StudentId",
                table: "BookTransfer",
                newName: "IX_BookTransfer_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransfers_BookId",
                table: "BookTransfer",
                newName: "IX_BookTransfer_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTransfer",
                table: "BookTransfer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfer_Books_BookId",
                table: "BookTransfer",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransfer_Students_StudentId",
                table: "BookTransfer",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
