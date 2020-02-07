using Microsoft.EntityFrameworkCore.Migrations;

namespace EMartCaseStudyMVC.Migrations.Item
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<double>(nullable: false),
                    item_name = table.Column<string>(nullable: true),
                    category_id = table.Column<int>(nullable: false),
                    scatogery_id = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    stockNO = table.Column<int>(nullable: false),
                    remarks = table.Column<string>(nullable: true),
                    Gst = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
