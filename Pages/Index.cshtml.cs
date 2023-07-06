using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class IndexModel : PageModel
{
    public List<Category> Systems;
    public List<Category> Scenarios;

    public IndexModel()
    {
        this.GetDataSystem();
        this.GetDataScenario();
    }

    public void GetDataSystem() {
        Systems = new List<Category>();
        Systems.Add(new Category{Id = 1, Title= "chiếu sáng", Icon = "fa-lightbulb-o"});
        Systems.Add(new Category{Id = 2, Title= "âm thanh đa vùng", Icon = "fa-music"});
        Systems.Add(new Category{Id = 3, Title= "an ninh", Icon = "fa-bell-o"});
        Systems.Add(new Category{Id = 4, Title= "camera giám sát", Icon = "fa-camera"});
        Systems.Add(new Category{Id = 5, Title= "điều hòa không khí", Icon = "fa-cloud-download"});
        Systems.Add(new Category{Id = 6, Title= "tưới tiêu - cây cảnh", Icon = "fa-leaf"});
        Systems.Add(new Category{Id = 7, Title= "rèm cửa", Icon = "fa-windows"});
        Systems.Add(new Category{Id = 8, Title= "đa phương tiện", Icon = "fa-play-circle-o"});
    }

    public void GetDataScenario() {
        Scenarios = new List<Category>();
        Scenarios.Add(new Category{Id = 1, Title= "good morning", Icon = "fa-clock-o", Description = "Vào 6h sáng, điều hòa sẽ tắt ở tất cả phòng ngủ, rèm được kéo ra, âm nhạc từ nguồn 1 sẽ phát lên với âm lượng tăng dần (volume sẽ tăng dần từ 20 đến 22 đến 24 sau mỗi phút)."});
        Scenarios.Add(new Category{Id = 2, Title= "cinema", Icon = "fa-film", Description = "Tại phòng phim, màn hình và máy chiếu được hạ xuống, toàn bộ hệ thống âm thanh được bật lên, tất cả đèn tắt đồng thời tất cả rèm sẽ được kéo lại đảm bảo ánh sáng đạt chuẩn cho buổi xem phim."});
        Scenarios.Add(new Category{Id = 3, Title= "happy hour", Icon = "fa-birthday-cake", Description = "Nhạc bật ở nguồn 2, bật đèn thả, đèn trần vàng và đèn quầy bar, mở các rèm ở phòng ăn và mở đèn tranh ở phòng khách."});
        Scenarios.Add(new Category{Id = 4, Title= "vacation", Icon = "fa-sun-o", Description = "Tất cả đèn, âm thanh, màn rèm, cổng cửa, bếp gas, điều hòa chuyển sang chế độ OFF, báo những vị trí cửa chưa được đóng lại, bật chế độ cảnh báo giả lập như có người ở nhà nếu phát hiện đột nhập."});
    }
}
