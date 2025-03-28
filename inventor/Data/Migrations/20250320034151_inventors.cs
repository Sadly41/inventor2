using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inventor.Migrations
{
    /// <inheritdoc />
    public partial class inventors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inventors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventors", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventors");
        }
    }
}
