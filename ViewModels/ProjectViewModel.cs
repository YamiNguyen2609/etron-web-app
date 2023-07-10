using System;

namespace AppWebCore.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public bool ImageExist { get; set; }
        public string Slug { get; set; }
        public bool Showing { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string GenderName {
            get {
                return Gender ? "Ông" : "Bà";
            }
        }
    }
}