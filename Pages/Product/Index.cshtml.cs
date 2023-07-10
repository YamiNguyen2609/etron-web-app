using Microsoft.AspNetCore.Mvc.RazorPages;
using AppWebCore.ViewModels;

namespace AppWebCore.Pages;

public class ProductModel : PageModel
{
    public List<ProductTypeViewModel> Products;
    private EtronContext _context;
    public ProductModel()
    {
        _context = new EtronContext();
        this.GetDataProducts();
    }

    public void OnGet()
    {
    }

    public void GetDataProducts() {
        Products = _context.ProductTypes.ToList().Select(item => new ProductTypeViewModel() {
            Title = item.Name,
            Icon = item.Icon,
            Id = item.Id
        }).ToList();
    }

    private List<ProductViewModel> ProductControl() {
        List<ProductViewModel> results = new List<ProductViewModel>();
        results.Add(new ProductViewModel() {
            Title = "công tắc cơ 3 nút",
            Name = "3-button wall switch",
            Code = "113A00-5",
            Description = "Công tắc gắn tường 3 nút nhấn thông minh chính hãng nguyên đai nguyên kiện từ <b>Leviton</b>. Công dụng bật/tắt dùng cho đèn, mô tơ rèm, ngữ cảnh... Có thể lập trình thay đổi công năng từng phím một.",
            Brand = "leviton",
            Origin = "USA",
            Image = new List<string> { "cong-tac-3-leviton.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "công tắc cơ 6 nút",
            Name = "6-button wall switch",
            Code = "113A00-8",
            Description = "Công tắc gắn tường 6 nút nhấn thông minh chính hãng nguyên đai nguyên kiện từ <b>Leviton</b>. Công dụng bật/tắt dùng cho đèn, mô tơ rèm, ngữ cảnh... Có thể lập trình thay đổi công năng từng phím một.",
            Brand = "leviton",
            Origin = "USA",
            Image = new List<string> { "cong-tac-6-leviton.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "công tắc điều khiển âm thanh",
            Name = "Volume source control",
            Code = "95A03-1",
            Description = @"Công tắc gắn tường điều khiển âm thanh đa vùng nhập từ chính hãng từ Leviton. Một chiếc công tắc nhỏ với nhiều công dụng:<br> 
                                    <ul>
                                        <li>Thay đổi nguồn nhạc</li>
                                        <li>Thay đổi bài hát</li>
                                        <li>Tăng giảm âm lượng</li>
                                    </ul>",
            Brand = "leviton",
            Origin = "USA",
            Image = new List<string> { "dieu-khien-am-thanh-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "công tắc cảm ứng 4 nút",
            Name = "4-button touch switch",
            Code = "SW-4C119",
            Description = @"Công tắc cảm ứng 4 phím bấm được ốp mặt kiếng sang trọng, hiện đại. Chức năng bật/tắt đèn, mô tơ rèm, ngữ cảnh… Có thể lập trình và thay đổi công năng từng phím một. Màu sắc đa dạng phù hợp với các chất liệu tường:
                                    <ul>
                                        <li>Đen/Trắng</li>
                                        <li>Vàng gold</li>
                                        <li>Đá quý</li>
                                        <li>Gỗ</li>
                                    </ul>",
            Brand = "Etron",
            Origin = "Nhật Bản",
            Image = new List<string> { 
                "cong-tac-4-cam-ung-den-etron.png", 
                "cong-tac-4-cam-ung-trang-etron.png",
                "cong-tac-4-cam-ung-vang-gold-etron.png",
                "cong-tac-4-cam-ung-da-etron.png",
                "cong-tac-4-cam-ung-go-etron.png",
            }
        });
        results.Add(new ProductViewModel() {
            Title = "công tắc cảm ứng 6 nút",
            Name = "6-button touch switch",
            Code = "SW-6C120",
            Description = @"Công tắc cảm ứng 6 phím bấm được ốp mặt kiếng sang trọng, hiện đại. Chức năng bật/tắt đèn, mô tơ rèm, ngữ cảnh… Có thể lập trình và thay đổi công năng từng phím một. Màu sắc đa dạng phù hợp với các chất liệu tường:
                                    <ul>
                                        <li>Đen/Trắng</li>
                                        <li>Vàng gold</li>
                                        <li>Đá quý</li>
                                    </ul>",
            Brand = "Etron",
            Origin = "Nhật Bản",
            Image = new List<string> { "cong-tac-6-cam-ung-den-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "keypad cảm ứng điều khiển điều hòa",
            Name = "ac control keypad",
            Code = "AC-KC110",
            Description = @"Keypad điều khiển điều hòa được ốp mặt kiếng đầy tinh tế và hiện đại trên tường. Bạn có thể bật/tắt điều hòa, tăng giảm nhiệt độ, tốc độ quạt cũng như các chế độ điều hòa chỉ bằng với keypad này. Màu sắc:
                                    <ul>
                                        <li>Đen</li>
                                        <li>Trắng</li>
                                    </ul>",
            Brand = "Etron",
            Origin = "Nhật Bản",
            Image = new List<string> { "keypad-dieu-hoa-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "màn hình trung tâm touch screen 21",
            Name = "center monitor touch screen",
            Code = "Intel",
            Description = @"Keypad điều khiển điều hòa được ốp mặt kiếng đầy tinh tế và hiện đại trên tường. Bạn có thể bật/tắt điều hòa, tăng giảm nhiệt độ, tốc độ quạt cũng như các chế độ điều hòa chỉ bằng với keypad này. Màu sắc:
                                    <ul>
                                        <li>Đen</li>
                                        <li>Trắng</li>
                                    </ul>",
            Brand = "Dell/HP",
            Origin = "USA",
            Image = new List<string> { "man-hinh-trung-tam-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "bộ cài đặt bảo mật hệ thống",
            Name = "hai omni lcd console",
            Code = "33A00-1",
            Description = @"Bộ phím lập trình, tạo mật khẩu an ninh và báo động được tích hợp dành riêng cho hệ thống bảo mật điện <b>Leviton</b>. Với thiết bị này trong hệ thống, gia chủ có thể cài đặt để bảo mật tuyệt đối hệ thống nhà của mình.",
            Brand = "Leviton",
            Origin = "USA",
            Image = new List<string> { "hai-omni-lcd-console-etron.png" }
        });

        return results;
    }

    private List<ProductViewModel> ProductMusic() {
        List<ProductViewModel> results = new List<ProductViewModel>();
        results.Add(new ProductViewModel() {
            Title = "âm ly đa vùng (4 vùng)",
            Name = "4-zone hai hift",
            Code = "95A00-3",
            Description = "Bộ âm ly phân phối hệ thống âm thanh đa vùng trong nhà. Đây là bộ amplifier tích hợp cho phép phát đồng cùng lúc 4 khu vực với 4 danh sách phát nhạc khác nhau. Chủ nhà có thể điều khiển bằng công tắc, màn hình trung tâm và ứng dụng điện thoại để mở và chọn bài nhạc yêu thích.",
            Brand = "HAI leviton",
            Origin = "USA",
            Image = new List<string> { "hifi-hai-4-vung-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "âm ly đa vùng (8 vùng)",
            Name = "8-zone hai hift",
            Code = "95A00-2",
            Description = "Bộ âm ly phân phối hệ thống âm thanh đa vùng trong nhà. Đây là bộ amplifier tích hợp cho phép phát đồng cùng lúc 4 khu vực với 8 danh sách phát nhạc khác nhau. Chủ nhà có thể điều khiển bằng công tắc, màn hình trung tâm và ứng dụng điện thoại để mở và chọn bài nhạc yêu thích.",
            Brand = "HAI leviton",
            Origin = "USA",
            Image = new List<string> { "hifi-hai-8-vung-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "bộ mở rộng âm thanh 8 vùng",
            Name = "8-zone hai hift expansion kit",
            Code = "95A12-2",
            Description = "Bộ mở rộng âm thanh đa vùng kết hợp với bộ Âm ly 8 vùng (Mã 95A00-2) để nâng lên 16 vùng nhạc phát cùng lúc. Với những ngôi biệt thự, tòa nhà lớn, chủ nhà có thể nâng cấp lên 16 vùng nhạc phát đồng thời với 16 nguồn phát nhạc cùng một lúc. Mỗi khu vực sẽ nghe nhạc riêng biệt với nhau mà không cần đầu âm ly riêng.",
            Brand = "HAI leviton",
            Origin = "USA",
            Image = new List<string> { "bo-mo-rong-8-vung-hifi-hai-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "cổng lưu trữ nhạc",
            Name = "hai music gateway",
            Code = "MG1000-4",
            Description = "Bộ âm ly phân phối hệ thống âm thanh đa vùng trong nhà. Đây là bộ amplifier tích hợp cho phép phát đồng cùng lúc 8 khu vực và phát đến 8 danh sách nhạc khác nhau. Chủ nhà có thể điều khiển bằng công tắc, màn hình trung tâm và ứng dụng điện thoại để mở và chọn bài nhạc yêu thích.",
            Brand = "HAI leviton",
            Origin = "USA",
            Image = new List<string> { "cong-luu-tru-nhac-etron.png" }
        });
        results.Add(new ProductViewModel() {
            Title = "loa âm trần flatline acounstics",
            Name = "flatline acoustics celling-spearkers",
            Code = "LPL-650-IC",
            Description = "Loa nghe nhạc âm trần chất lượng cao với công suất phát lên đến 125W.",
            Brand = "Flatline Acoustics",
            Origin = "USA",
            Image = new List<string> { "loa-am-tran-flatline-etron.png" }
        });
        return results;
    }
}

