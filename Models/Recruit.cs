using System;

namespace AppWebCore.Models
{
    public class Recruit
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}