using System;
using Microsoft.AspNetCore.Mvc;


namespace AppWebCore.ViewModels
{
    public class LoginViewModel
    {
        [BindProperty]
        public string Username {get; set; }
        [BindProperty]
        public string Password { get; set; }
    }
}