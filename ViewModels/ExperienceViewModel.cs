using System;
using Microsoft.AspNetCore.Mvc;


namespace AppWebCore.ViewModels
{
    public class ExperienceViewModel
    {
        [BindProperty]
        public string Title {get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Link { get; set; }
    }
}