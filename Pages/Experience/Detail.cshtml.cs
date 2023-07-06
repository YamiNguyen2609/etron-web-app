using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class ExperienceDetailModel : PageModel
{
    public ExperienceViewModel Experience;
    public ExperienceDetailModel()
    {
    }

    public void OnGet(string name)
    {
        Experience = new ExperienceViewModel();
        switch (name.ToLower())
        {
            case "phong-khach": {
                Experience.Title = "phòng Khách";
                Experience.Name = "LivingRoom";
                return;
            }
            case "phong-phim": {
                Experience.Title = "phòng phim";
                Experience.Name = "MovieRoom";
                return;
            }
            case "san-vuon": {
                Experience.Title = "sân vườn";
                Experience.Name = "Graden";
                return;
            }
            default:
                return;
        }
    }
}

