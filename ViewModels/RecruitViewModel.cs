using System;

namespace AppWebCore.ViewModels
{
    public class RecruitViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string DateString { get {
            return DateCreated.ToString("dd-MM-yyyy HH:mm:ss");
        }}
    }
}