using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class RecruitModel : PageModel
{
    private EtronContext _context;
    public List<RecruitViewModel> Recruitments;
    public RecruitModel()
    {
        _context = new EtronContext();
        Recruitments = this.getRecruitments();
    }

    public void OnGet()
    {
    }

    public List<RecruitViewModel> getRecruitments() {
        return _context.Recruitments.ToList().Select(item => new RecruitViewModel() {
            Id = item.Id,
            Title = item.Title,
            Image = item.Image,
            Slug = item.Slug,
            DateCreated = item.DateCreated,
            Description = item.Description
        }).ToList();
    }
}

