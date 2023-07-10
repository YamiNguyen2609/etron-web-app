using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class ProjectDetailModel : PageModel
{
    // public ProjectViewModel Project;
    public ProjectDetailModel()
    {
    }

    public void OnGet(string name)
    {
        // Project = new ProjectViewModel();
        // switch (name.ToLower())
        // {
        //     case "phong-khach": {
        //         Project.Title = "phòng Khách";
        //         Project.Name = "LivingRoom";
        //         return;
        //     }
        //     case "phong-phim": {
        //         Project.Title = "phòng phim";
        //         Project.Name = "MovieRoom";
        //         return;
        //     }
        //     case "san-vuon": {
        //         Project.Title = "sân vườn";
        //         Project.Name = "Graden";
        //         return;
        //     }
        //     default:
        //         return;
        // }
    }
}

