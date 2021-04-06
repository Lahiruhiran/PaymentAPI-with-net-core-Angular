using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentAPI1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyPayment",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardHName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    cardNo = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    expireDate = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    Securitycode = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPayment", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyPayment");
        }
    }
}
