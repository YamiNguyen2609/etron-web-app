using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class LoginModel : PageModel
{
    public LoginModel()
    {
    }

    public void OnGet()
    {
    }

    public IActionResult OnPostSubmitLogin(LoginViewModel model) {
        return Redirect("/quan-ly-he-thong");
    }
}

