using System;

namespace AppWebCore.ViewModels
{
    public class ProductTypeViewModel
    {
        public ProductTypeViewModel() {
            Products = new List<ProductViewModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public List<ProductViewModel> Products {get; set;}
    }
}