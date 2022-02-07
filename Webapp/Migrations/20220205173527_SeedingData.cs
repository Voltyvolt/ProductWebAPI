using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapp.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Images", "Price", "ProductName", "Timestamp", "productDetail" },
                values: new object[] { 1, "D:\\Pyt\\Webapp\\Webapp\\assets\\battlecreek1", 199.0, "Battlecreek Coffee", "06/02/2022", "กาแฟนำเข้าจากอเมริกา รสชาติกลมกล่อม" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Images", "Price", "ProductName", "Timestamp", "productDetail" },
                values: new object[] { 2, "D:\\Pyt\\Webapp\\Webapp\\assets\\eniko", 1969.0, "eniko", "06/02/2022", "กล้องฟิล์มหายาก" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Images", "Price", "ProductName", "Timestamp", "productDetail" },
                values: new object[] { 3, "D:\\Pyt\\Webapp\\Webapp\\assets\\galina", 320.0, "galina", "06/02/2022", "กระถางต้นไม้สวยๆ ไว้ประดับบ้าน" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Images", "Price", "ProductName", "Timestamp", "productDetail" },
                values: new object[] { 4, "D:\\Pyt\\Webapp\\Webapp\\assets\\jakob", 670.0, "jakob", "06/02/2022", "กระเป๋าหนังแท้รุ่น Limited" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Email", "Name", "Password", "UserName" },
                values: new object[] { 1, "admin@gmail.com", "Admin", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Email", "Name", "Password", "UserName" },
                values: new object[] { 2, "ratchanon0123@gmail.com", "รัชชานนท์ ถูกนึก", "1234", "volt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
