using AppWebCore.Models;

namespace AppWebCore
{
    public static class DbInitializer
    {
        public static void Initialize(EtronContext context) {
            if(context.ProductTypes.Any())
                return;
            
            var productTypes = new ProductType[] {
                new ProductType { Id = 1, Name = "Phím điều khiển", Icon = "fa-calculator" },
                new ProductType { Id = 2, Name = "Hệ thống âm thanh", Icon = "fa-music" },
                new ProductType { Id = 3, Name = "Hệ thống cảm biến", Icon = "fa-code-fork" }
            };

            context.ProductTypes.AddRange(productTypes);
            context.SaveChanges();
        }
    }
}