using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class ContactModel : PageModel
{
    public List<BranchViewModel> Branchs;
    public ContactModel()
    {
        this.GetDataContact();
    }

    public void OnGet()
    {
        string x = "";
    }

    public void GetDataContact()
    {
        Branchs = new List<BranchViewModel>();
        Branchs.Add(new BranchViewModel
        {
            Id = 1,
            Location = "Hồ Chí Minh",
            Address = "26 Cao Triều Phát, P. Tân Phong, Q.7",
            Phone = "028 5411 0066",
            Fax = "028 5411 0660",
            Email = "hcm@etron.com.vn"
        });
        Branchs.Add(new BranchViewModel
        {
            Id = 1,
            Location = "Hà Nội",
            Address = "Chu Huy Mân, Long Biên, Hà Nội",
            Phone = "028 5411 0066",
            Email = "hn@etron.com.vn"
        });
        Branchs.Add(new BranchViewModel
        {
            Id = 1,
            Location = "Đà Nẵng",
            Address = "Tầng 14, tòa nhà Phi Long, 52 Nguyễn Văn Linh, Q. Hải Châu",
            Phone = "0236 3888 000",
            Fax = "0236 3653 000",
            Email = "dn@etron.com.vn"
        });
    }

    public IActionResult  OnPostSubmitContact(ContactViewModel model) {
        return Redirect("/lien-he-thanh-cong");
    }
}

