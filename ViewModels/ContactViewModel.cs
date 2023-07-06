using System;
using Microsoft.AspNetCore.Mvc;


namespace AppWebCore.ViewModels
{
    public class ContactViewModel
    {
        [BindProperty]
        public string Name {get; set; }
        [BindProperty]
        public string Phone { get; set; }   
        [BindProperty]     
        public string Email { get; set; }
        [BindProperty]
        public string Description { get; set; }
    }
}