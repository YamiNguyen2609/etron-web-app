using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages.Manager;

public class IndexModel : PageModel
{
    public List<Category> Systems;
    public List<Category> Scenarios;

    public IndexModel()
    {
    }
}