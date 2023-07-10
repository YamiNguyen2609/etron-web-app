using AppWebCore.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppWebCore.Pages;

public class ProjectModel : PageModel
{
    [Obsolete]
    private Microsoft.AspNetCore.Hosting.IHostingEnvironment _env;
    public List<ProjectViewModel> Projects;
    private EtronContext _context;

    [Obsolete]
    public ProjectModel(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
    {
        _context = new EtronContext();
        _env = env;
        this.getProjects();
    }

    public void OnGet()
    {
    }

    public void getProjects() {
        Projects = _context.Projects.ToList().Select(item => new ProjectViewModel() {
            Id = item.Id,
            Gender = item.Gender,
            Owner = item.Owner,
            Image = item.Image,
            Address = item.Address,
            ImageExist = System.IO.File.Exists(_env.WebRootPath + "/image/" + item.Image),
            Slug = item.Slug
        }).ToList();
    }
}

