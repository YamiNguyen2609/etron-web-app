using System;
using Microsoft.AspNetCore.Mvc;


namespace AppWebCore.ViewModels
{
    public class ProductViewModel
    {
        [BindProperty]
        public string Title {get; set; }
        [BindProperty]
        public string Name { get; set; }   
        [BindProperty]     
        public string Code { get; set; }
        [BindProperty]
        public string Description { get; set; }
        [BindProperty]     
        public string Brand { get; set; }
        [BindProperty]
        public string Origin { get; set; }
        [BindProperty]
        public List<string> Image { get; set; }
        public List<ProductViewModel> Products { get; set; }
        [BindProperty]
        public string FullCode { get {
            return Code + "/" + Brand + "/" + Origin;
        }}
    }
}