using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class FaqModel : PageModel
{
    private EtronContext _context;
    public List<FaqViewModel> Faqs;
    public FaqModel()
    {
        _context = new EtronContext();
        Faqs = this.getFaqs();
    }

    public void OnGet()
    {
    }

    public List<FaqViewModel> getFaqs() {
        return _context.Faqs.ToList().Select(item => new FaqViewModel() {
            Id = item.Id,
            Question = item.Question,
            Anwser = item.Anwser
        }).ToList();
    }
}

