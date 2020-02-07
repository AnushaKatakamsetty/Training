

using Microsoft.EntityFrameworkCore.Migrations;

namespace EMartCaseStudyMVC.Migrations.Seller
{
    public partial class sellercreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sname = table.Column<string>(nullable: true),
                    spassword = table.Column<string>(nullable: true),
                    scompanyname = table.Column<string>(nullable: true),
                    sgstin = table.Column<string>(nullable: true),
                    saboucompany = table.Column<string>(nullable: true),
                    saddress = table.Column<string>(nullable: true),
                    swebsite = table.Column<string>(nullable: true),
                    semailid = table.Column<string>(nullable: true),
                    smobileno = table.Column<long>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seller");
        }
    }
}
