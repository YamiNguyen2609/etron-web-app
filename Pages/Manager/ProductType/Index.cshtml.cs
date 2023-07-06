
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.Models;

namespace AppWebCore.Pages.Manager;

public class ProductTypeModel : PageModel
{
    private readonly EtronContext _context;
    public List<Models.ProductType> Items {get;set;}
    public ProductTypeModel()
    {
        _context = new EtronContext();
    }

    public void OnGet()
    {
        Items = _context.ProductTypes.ToList();
    }
}

