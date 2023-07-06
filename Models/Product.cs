using System;

namespace AppWebCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
    }
}