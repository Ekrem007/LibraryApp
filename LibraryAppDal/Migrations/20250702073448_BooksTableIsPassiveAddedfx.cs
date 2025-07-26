using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAppDal.Migrations
{
    /// <inheritdoc />
    public partial class BooksTableIsPassiveAddedfx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPassive",
                table: "Books",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPassive",
                table: "Books");
        }
    }
}
