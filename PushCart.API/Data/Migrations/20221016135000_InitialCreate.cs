using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PushCart.API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<double>(type: "REAL", nullable: false),
                    IsPickedUp = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "IsPickedUp", "ItemName", "Quantity" },
                values: new object[] { 1, true, "Chilli Powder", 1.0 });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "IsPickedUp", "ItemName", "Quantity" },
                values: new object[] { 2, false, "Garlic Powder", 2.0 });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "IsPickedUp", "ItemName", "Quantity" },
                values: new object[] { 3, true, "Tooth Brush", 3.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");
        }
    }
}
