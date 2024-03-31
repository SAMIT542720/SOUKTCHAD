using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOUKTCHAD.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CATIGORYS",
                newName: "CATIGORYID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CATIGORYID",
                table: "CATIGORYS",
                newName: "ID");
        }
    }
}
