using Microsoft.EntityFrameworkCore.Migrations;

namespace Mango.Services.ProductAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizet", "Samosa Description", "", "Samosa", 15.0 },
                    { 2, "Appetizet", "Paneer Tikka Description", "", "Paneer Tikka", 13.99 },
                    { 3, "Dessert", "Sweet Pie Description", "", "Sweet Pie", 10.99 },
                    { 4, "Entree", "Pav Bhaji Description", "", "Pav Bhaji", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
