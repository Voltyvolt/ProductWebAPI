using Microsoft.EntityFrameworkCore;

namespace Webapp.Helper
{
    public static class SeedingData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                   new User { id = 1, Name = "Admin", UserName = "admin", Password = "admin", Email = "admin@gmail.com" },
                   new User { id = 2, Name = "รัชชานนท์ ถูกนึก", UserName = "volt", Password = "1234", Email = "ratchanon0123@gmail.com" }

               );

            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, ProductName = "Battlecreek Coffee", productDetail = "กาแฟนำเข้าจากอเมริกา รสชาติกลมกล่อม", Price = 199.00, Images = "/assets/battlecreek1.jpg", Timestamp = DateTime.Now.ToString("dd/MM/yyyy") },
                    new Product { Id = 2, ProductName = "eniko", productDetail = "กล้องฟิล์มหายาก", Price = 1969.00, Images = "/assets/eniko.jpg", Timestamp = DateTime.Now.ToString("dd/MM/yyyy") },
                    new Product { Id = 3, ProductName = "galina", productDetail = "กระถางต้นไม้สวยๆ ไว้ประดับบ้าน", Price = 320.00, Images = "/assets/galina.jpg", Timestamp = DateTime.Now.ToString("dd/MM/yyyy") },
                    new Product { Id = 4, ProductName = "jakob", productDetail = "กระเป๋าหนังแท้รุ่น Limited", Price = 670.00, Images = "/assets/jakob.jpg", Timestamp = DateTime.Now.ToString("dd/MM/yyyy") }

                );
        }
    }
}
