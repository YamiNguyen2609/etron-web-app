using AppWebCore.Models;

namespace AppWebCore
{
    public static class DbInitializer
    {
        public static void Initialize(EtronContext context) {
            if(!context.ProductTypes.Any()) {
            
                var productTypes = new ProductType[] {
                    new ProductType { Id = 1, Name = "Phím điều khiển", Icon = "fa-calculator" },
                    new ProductType { Id = 2, Name = "Hệ thống âm thanh", Icon = "fa-music" },
                    new ProductType { Id = 3, Name = "Hệ thống cảm biến", Icon = "fa-code-fork" }
                };

                context.ProductTypes.AddRange(productTypes);
                context.SaveChanges();
            }

            if(!context.Projects.Any()) {
                var projects = new Project[] {
                    new Project { Id = 1, Owner = "KHÁNH", Gender = true, Address = "Vinhomes Riverside, TP. Hà Nội", Image = "pro-nguyen-trong-khanh.png", Slug = "khanh", Showing = true, Description = "Biệt thự thông minh tại biệt khu Vinhomes Riverside của Mr. Khánh tại Hà Nội" },
                    new Project { Id = 2, Owner = "ĐÔNG", Gender = true, Address = "Khu Biệt Thự Đào Xanh, Đà Nẵng", Image = "pro-huynh-thanh-dong.png", Slug = "dong", Showing = true, Description = "Dự án nhà thông minh cao cấp Etron Smarthome tại khu biệt thự Đảo Xanh tại Đà Nẵng" },
                    new Project { Id = 3, Owner = "PHƯƠNG", Gender = true, Address = "Quảng Phú, TP. Quảng Ngãi", Image = "pro-tran-ngoc-phuong.png", Slug = "phuong", Showing = true, Description = "Công trình nhà thông minh có dây Leviton full tính năng tại Quảng Ngãi do đội ngũ Etron Smarthome lắp đặt năm 2016" },
                    new Project { Id = 4, Owner = "HOÀI", Gender = true, Address = "Cam Ranh, Khánh Hòa", Image = "pro-tran-van-hoai.png", Slug = "hoai", Showing = true, Description = "Công trình thông minh giải pháp toàn diện tại Khánh Hòa của Etron Smarthome vừa ký kết giữa năm 2017 " },
                    new Project { Id = 5, Owner = "BẰNG", Gender = true, Address = "TT. Eakar, Đăk Lăk", Image = "pro-nguyen-trung-bang.png", Slug = "bang", Showing = true, Description = "Căn biệt thự quy mô lớn tại Phố núi với thiết kế chuẩn có dây và full tất cả bộ giải pháp thông minh từ Etron Smarthome " },
                    new Project { Id = 6, Owner = "TRUNG", Gender = true, Address = "Bình Giã, TP. Vũng Tàu", Image = "pro-tran-xuan-trung.png", Slug = "trung", Showing = true, Description = "Dự án Smarthome cao cấp 3 tầng lầu do Etron lắp đặt tại trung tâm thành phố Vũng Tàu" },
                    new Project { Id = 7, Owner = "TÂM", Gender = true, Address = "TP. Biên Hòa, Đồng Nai", Image = "pro-phan-ho-canh-tam.png", Slug = "tam", Showing = true, Description = "Dự án điện thông minh hệ có dây full option hãng Leviton tại biệt thự anh Tâm tại Biên Hòa Đồng Nai" },
                    new Project { Id = 9, Owner = "DÂN", Gender = true, Address = "TP. Thủ Dầu Một, Bình Dương", Image = "pro-to-van-dan.png", Slug = "dan", Showing = true, Description = "Một trong những công trình Smarthome cao cấp đầu tiên do Etron xây lắp tại Bình Dương được chủ nhà đánh giá rất cao" },
                    new Project { Id = 10, Owner = "VŨ MINH TRÍ", Gender = true, Address = "Căn Hộ Happy Valley, Hồ Chí Minh", Image = "pro-vu-minh-tri.png", Slug = "vu-minh-tri", Showing = true, Description = "Căn hộ cao cấp thông minh Etron Smarthome của Nguyên Tổng Giám Đốc Microsoft Việt Nam Vũ Minh Trí" },
                    new Project { Id = 14, Owner = "VÂN", Gender = false, Address = "Phú Mỹ Hưng, Hồ Chí Minh", Image = "pro-nguyen-thi-hong-van.png", Slug = "van", Showing = true, Description = "Căn biệt thự tại nội khu phú Mỹ Hưng là công trình điện thông minh tiêu biểu khởi công năm 2016 của Etron Smarthome" },
                    new Project { Id = 18, Owner = "PHƯƠNG", Gender = false, Address = "Khu Thảo Điền, Hồ Chí Minh", Image = "cong-trinh-etron-mach-hong-phuong.png", Slug = "phuong", Showing = true, Description = "Công trình điện thông minh cao cấp chị Phương tại khu biệt thự hạng sang Thảo Điền Quận 2" },
                    new Project { Id = 20, Owner = "DŨNG", Gender = true, Address = "Khu Phú Mỹ, Phú Mỹ Hưng", Image = "cong-trinh-etron-dung-spa.png", Slug = "dung", Showing = true, Description = "Công trình biệt thự lớn sử dụng giải pháp nhà thông minh không dây sóng Zigbee từ Etron Smarthome sử dụng đến nay đã lâu nhưng đảm bảo ổn định" },
                    new Project { Id = 21, Owner = "NGUYỄN PHI LONG", Gender = true, Address = "Khu Biệt Thự Đào Xanh, Đà Nẵng", Image = "etron-cong-trinh-ong-long.png", Slug = "nguyen-phi-long", Showing = true, Description = "Dự án nhà thông minh của Tổng giám đốc công ty Công nghệ Phi Long. Một trong những công ty về cung cấp máy tính, thiết bị điện tử và phần mềm" },
                    new Project { Id = 22, Owner = "SƠN", Gender = true, Address = "Khu Biệt Thự Đào Xanh, Đà Nẵng", Image = "cong-trinh-etron-ho-anh-son.png", Slug = "son", Showing = true, Description = "Thêm 1 công trình biệt thự cao cấp tại khu biệt thự Đảo Xanh xây lắp hệ thống nhà thông minh cao cấp Leviton do Etron Smarthome thi công" },
                    new Project { Id = 23, Owner = "THÔNG", Gender = true, Address = "Khu Biệt Thự Đào Xanh, Đà Nẵng", Image = "etron-cong-trinh-ong-thong.png", Slug = "thong", Showing = true, Description = "Căn biệt thự thông minh VIP tại khu biệt thự Đảo Xanh với gói Smarthome Full Option" },
                    new Project { Id = 24, Owner = "HUY", Gender = true, Address = "Phú Mỹ Hưng, Hồ Chí Minh", Image = "etron-cong-trinh-ong-huy-1.png", Slug = "huy", Showing = true, Description = "Công trình nhà ở thông minh của gia đình anh Lâm Chấn Huy - Chủ tiệm trà và cafe lớn và có tiếng tại Việt nam" },
                    new Project { Id = 25, Owner = "HÂN", Gender = true, Address = "Phú Mỹ Hưng, Tp. Hồ Chí Minh", Image = "etron-cong-trinh-ong-han.png", Slug = "han", Showing = true, Description = "Một trong những công trình nhà ở thông minh đầu tiên mà Etron Smarthome xây lắp tại Phú Mỹ Hưng" },
                    new Project { Id = 26, Owner = "SƠN", Gender = true, Address = "Khu Chateau, Hồ Chí Minh", Image = "cong-trinh-etron-mrson.png", Slug = "son", Showing = true, Description = "Chateau là khu biệt thự hạng sang nhất tại nội đô Phú Mỹ Hưng. Tại đây Etron Smarthome có dịp xây lắp hệ thống nhà thông minh không dây cho chủ dự án" },
                    new Project { Id = 27, Owner = "TÙNG", Gender = true, Address = "Khu Tân Quy Đông, Hồ Chí Minh", Image = "cong-trinh-thong-minh-anh-tung_Artboard 4.jpg", Slug = "tung", Showing = true, Description = "Công trình nhà ở hiện đại kết hợp sử dụng hệ thống điện thông minh Smarthome cao cấp Etron Smarthome" },
                    new Project { Id = 28, Owner = "MƯỜI", Gender = true, Address = "Phú Nhuận, Hồ Chí Minh", Image = "cong-trinh-nha-thong-minh-etron-ong-muoi.png", Slug = "muoi", Showing = true, Description = "Một trong những công trình nhà ở thông minh làm Smarthome đầu tiên mà Etron ký tại Tp. Hồ Chí Minh " },
                    new Project { Id = 29, Owner = "TÂM", Gender = true, Address = "Phú Mỹ Hưng, Hồ Chí Minh", Image = "cong-trinh-etron-anh-tam.png", Slug = "tam", Showing = true, Description = "Biệt thự thông minh của anh Tâm - Công ty nệm Kim Đan mà Etron có dịp được xây lắp tại đây" },
                    new Project { Id = 30, Owner = "VIẾT", Gender = true, Address = "Khu Biệt Thự Đào Xanh, Đà Nẵng", Image = "cong-trinh-etron-ong-viet-da-nang.png", Slug = "viet", Showing = true, Description = "Công trình nhà ở Smarthome cao cấp của khách VIP Etron Smarthome tại Đà Nẵng" },
                    new Project { Id = 33, Owner = "THẮNG", Gender = true, Address = "Khu LACASA, Hồ Chí Minh", Image = "cong-trinh-thong-minh-etron-ong-thang.png", Slug = "thang", Showing = true, Description = "Một trong những \"siêu\" dự án mà Etron ký kết năm 2017 với gói giải pháp toàn bộ A đến Z trên diện tích 1000m2 công trình" },
                    new Project { Id = 34, Owner = "ĐẠT", Gender = true, Address = "Nhà Bè, Hồ Chí Minh", Image = "cong-trinh-etron-nha-anh-dat.png", Slug = "dat", Showing = true, Description = "Công trình không dây Etron vừa hoàn thành cuối năm 2017 với các giải pháp chiếu sáng, mành rèm, cổng cửa, âm thanh..." },
                    new Project { Id = 35, Owner = "LĨNH", Gender = true, Address = "Phú Mỹ Hưng, Hồ Chí Minh", Image = "cong-trinh-etron-anh-linh.png", Slug = "linh", Showing = true, Description = "Dự án villa biệt thự thông minh cao cấp tại Phú Mỹ Hưng do Etron Smarthome xây lắp hoàn thành vào đầu năm 2018" },
                    new Project { Id = 36, Owner = "THƯƠNG", Gender = false, Address = "Phú Mỹ Hưng, Hồ Chí Minh", Image = "cong-trinh-nha-chi-thuong-rs.png", Slug = "thuong", Showing = true, Description = "Dự án nhà thông minh nhà chị Thương thiết kế theo phong cách cổ điển đầy sang trọng và cao quý" }
                };
                
                context.Projects.AddRange(projects);
                context.SaveChanges();
            }
        
            if(!context.Faqs.Any()) {
                var faqs = new Faq[] {
                    new Faq { Id = 1, Question = "Tôi có thể điều khiển nhà thông minh <b>Etron</b> bằng cách nào?", Anwser = "Nhà thông minh <b>Etron</b> có thể điều khiển bằng 4 cách thức: qua công tắc, sử dụng điện thoại, thao tác trên màn hình trung tâm 21'' và có thể sử dụng giọng nói để điều khiển"},
                    new Faq { Id = 3, Question = "Tôi thấy <b>Etron Smarthome</b> khai thác phím bấm cơ học LEVITON và cả phím bấm cảm ứng có nhãn Etron. Vậy nghĩa là sao?", Anwser = "Etron Smarthome là đơn vị khai thác giải pháp nhà thông minh của hãng LEVITON (Mỹ). Trong đó, hệ thống điện LEVITON chỉ có thể điều khiển duy nhất bằng phím bấm cơ học do LEVITON sản xuất. Tuy nhiên, để mang đến nhiều sự lựa chọn cũng như nhu cầu của khách hàng, Etron Smarthome phát triển thêm phím bấm cảm ứng với mạch điện được lắp ráp tại Nhật Bản và vỏ mặt nạ do Etron tự gia công. Tất nhiên, trong một nhà thì chủ nhà có thể chọn 1 trong 2 mẫu công tắc hoặc sử dụng kết hợp cũng được."},
                    new Faq { Id = 4, Question = "Điều khiển bằng giọng nói hoạt động như thế nào?", Anwser = "Điều khiển giọng nói là công nghệ đang được Etron Smarthome phát triển. Khác với công nghệ giọng nói của Alexa hay Google, trợ lý ảo Etrona học câu lệnh tiếng Việt nên chủ nhà có thể ra lệnh bằng tiếng Việt. Tuy nhiên vì công nghệ này chưa ra mắt chính thức nên Etron tặng bộ điều khiển giọng nói cho chủ nhà khi họ muốn."},
                    new Faq { Id = 5, Question = "Để triển khai giải pháp nhà thông minh thì cần thời gian thi công bao lâu?", Anwser = "Hiện tại Etron Smarthome khai thác 2 hệ: có dây và không dây. Hệ có dây thì sẽ lắp đặt giải pháp và đi dây cùng với đội thi công công trình (thời gian có thể từ 6 tháng - 1 năm). Hệ không dây thì chỉ lắp đặt hệ thống trên công trình có sẵn & không cần đục tường chạy dây, thời gian thi công khoảng (vài ngày đến 1 tháng tùy theo tính năng lắp đặt)"},
                    new Faq { Id = 6, Question = "Nhà tôi đã hoàn thiện rồi thì giờ muốn làm thông minh thì sao?", Anwser = "Đối với công trình đã hoàn thiện và đi vào sử dụng rồi, nếu gia chủ muốn lắp hệ thống thông minh thì có thể chọn giải pháp không dây. Hệ thống không dây có thể được lắp đặt nhanh chóng mà không cần đục dây. Với những hạng mục chiếu sáng, điều khiển rèm, ngữ cảnh thì chỉ cần thay thế công tắc truyền thống bằng phím bấm thông minh của Etron (thay lắp trong tuần). Với những nhu cầu cao hơn như âm thanh đa vùng, làm cảm biến tự động bật sáng thì có thể cần thời gian đi dây một vài chỗ."},
                    new Faq { Id = 7, Question = "Tôi có thể điều khiển các thiết bị bên ngoài như: cổng cửa, vòi tưới cây, motor hồ bơi được không?", Anwser = "Các thiết bị như cổng cửa, vòi tưới, hệ thống phun sục hồ bơi được hoạt động bởi các motor điện. Những motor này có thể được điều khiển đóng ngắt bởi hệ thống của Etron Smarthome"},
                    new Faq { Id = 8, Question = "Etron Smarthome có thể tạo ra ngữ cảnh theo cách sinh hoạt riêng của gia đình tôi được không?", Anwser = "\"Ngữ cảnh\" là cụm từ để chỉ sự hoạt động của nhiều thiết bị cùng một lúc để tạo ra một kịch bản sinh hoạt. Với hệ thống điện thông minh, chúng tôi có thể lập trình bất kỳ ngữ cảnh nào theo mong muốn chủ nhà. Ví dụ cài đặt ngữ cảnh \"thư giãn sân vườn\": Đèn nhà sẽ tắt, rèm kéo lại, đèn sân vườn sẽ bật lên, âm nhạc sân vườn cũng đồng thời phát nhạc Source 2 - nhạc cổ điển."},
                    new Faq { Id = 9, Question = "Hệ thống nhà thông minh LEVITON có gì khác so với các thương hiệu đang triển khai khác hiện nay? Nổi bật nhất là gì?", Anwser = "Công nghệ nhà thông minh LEVITON là hệ thống nhà thông minh hiện đại vào bậc nhất hiện nay được cung cấp bởi tập đoàn LEVITON của Mỹ. Đây là hệ thống đã được rất nhiều khách hàng lựa chọn vì là một giải pháp công nghệ an toàn và đáp ứng được  những nhu cầu sử dụng thiết thực nhất của khách hàng."},
                    new Faq { Id = 10, Question = "Bộ điều khiển trung tâm là gì, có tác dụng như thế nào trong hệ thống nhà thông minh LEVITON?", Anwser = "Bộ điều khiển trung tâm là bộ điều khiển có chức năng kết nối tất cả các thiết bị trong hệ thống trở thành một hệ thống điều khiển tổng quát. Bộ điều khiển trung tâm sẽ gửi tất cả các thông tin của ngôi nhà qua một màn hình điều khiển trung tâm, ứng dụng trên điện thoại... Ngoài ra tính năng chính của bộ điều khiển trung tâm là quản lý ngữ cảnh, tiếp nhận tín hiệu và xử lý tác vụ lênh điều khiển"},
                    new Faq { Id = 11, Question = "Bộ điều khiển trung tâm chỉ là hệ thống liên kết các hệ thống khác thành một bộ điều khiển chung thôi hay còn chức năng nào khác?", Anwser = "Ngoài chức năng xử lý kịch bản, bộ điều khiển trung tâm còn các chức năng khác như: xử lý đóng ngắt, xử lý relay module, các cảm biến, xử lý tín hiệu âm thanh đa vùng."},
                    new Faq { Id = 12, Question = "Sử dụng giải pháp điều khiển trung tâm của LEVITON, nếu bị hư thiết bị, thì có ảnh hưởng hết toàn bộ hệ thống không? ", Anwser = "Bộ điều khiển trung tâm chỉ kết nối các thiết bị khác lại thôi, về cơ bản khi hư thiết bị nào thì thay ở phần đó, không ảnh hưởng nhiều. Nếu bộ trung tâm có vấn đề, khi đó hệ thống nhà thông minh sẽ vẫn điều khiển được thông qua các nút bấm tại các vị trí lắp đặt sẵn trên tường."},
                    new Faq { Id = 13, Question = "Khi bị mất điện, có ảnh hưởng gì đến hệ thống? Phương án dự phòng?", Anwser = "Vâng, về cơ bản các hệ thống nhà thông minh khác trên thế giới hiện nay nói chung và hệ thống nhà thông minh LEVITON nói riêng mà Etron cung cấp đều sử dụng chủ yếu dựa vào hệ thống điện. Vậy nên khi mất điện hệ thống sẽ tạm ngưng hoạt động cho đến khi vấn đề mất điện được giải quyết. Tùy thuộc vào nhu cầu sử dụng riêng của từng khách hàng, chúng ta có thể khắc phục bằng cách lắp thêm các bộ UPS (có thể lưu điện được 2 ngày) để kích hoạt sử dụng một phần hệ thống như: cổng, cửa….Tuy nhiên để đảm bảo hoạt động, quý khách hàng có thể tích hợp thêm máy phát điện công suất cao để đảm bảo cả hệ thống hoạt động bình thường."},
                    new Faq { Id = 14, Question = "Tại sao giá bên LEVITON cao hơn nhiều so với các bên khác?", Anwser = "Giải pháp nhà thông minh LEVITON là một trong những giải pháp hàng đầu thế giới, được Etron Smarthome độc quyền phân phối tại Việt nam. Do đó tất cả các sản phẩm của LEVITON đều được nhập khẩu từ Mỹ và các thiết bị dây cáp, thiết bị điện đều là hãng chính hãng tại Mỹ hoặc các nhãn hiệu nổi tiếng sản xuất."},
                    new Faq { Id = 15, Question = "Trường hợp khách cần nâng cấp, thay đổi thiết bị sau 1 thời gian sử dụng? Etron Smarthome hỗ trợ như thế nào?", Anwser = "Giải pháp của Etron Smarthome sẽ được bảo hành trong 2 năm 1 đổi 1 và bảo trì thiết bị trong 5 năm. Việc thay đổi thiết bị sẽ được Etron hỗ trợ qua Hotline Kỹ Thuật 1800 7000. "},
                    new Faq { Id = 16, Question = "Khi khách hàng không muốn xài hệ thống này nữa, muốn xài công tắc cơ bình thường thì phải làm sao?", Anwser = "Hệ thống nhà thông minh Etron Smarthome là một sản phẩm kết hợp hoàn hảo của hệ thống thông minh và hệ thống cơ bình thường. Quý khách có thể trực tiếp sử dụng giải pháp này trên smartphone, Ipad, Tablet, màn hình trung tâm và các phím cơ do LEVITON cung cấp trên tường nhà như một hệ thống điện bình thường."},
                    new Faq { Id = 17, Question = "Hệ thống có thể điều chỉnh tăng hoặc giảm nhiệt độ, điều khiển tốc độ máy lạnh như remote được hay không? ", Anwser = "Điều này hoàn toàn có thể, hệ thống của Etron Smarthome có những bộ cảm biến hồng ngoại kết nối trực tiếp đến điều hòa cùng bộ công tắc điều khiển cho phép chủ nhà điều khiển máy lạnh giống hệt sử dụng Remote."},
                    new Faq { Id = 18, Question = "Âm thanh đa vùng tại Etron Smarthome có gì đặc biệt không?", Anwser = "Hầu hết giải pháp Smarthome nào cũng có hệ thống âm thanh đa vùng. Tại Etron, khách hàng có thể chọn số vùng từ 4 hoặc 8 hoặc 16 cho đến 32 vùng âm thanh độc lập khác nhau. Các vùng âm thanh này kết nối với 1 nguồn amplifier duy nhất và trữ được hơn 26,000 bài hát lossless chất lượng cao. Tất nhiên chủ nhà cũng có thể nghe nhạc online trong hệ thống này"},
                    new Faq { Id = 19, Question = "Tôi muốn điều khiển phòng giải trí của mình bao gồm chức năng xem phim 4K, phim 3D, karaoke thì có thể dùng hệ thống thông minh được không?", Anwser = "Tất nhiên là được, Etron Smarthome có thể kết nối với các thiết bị giải trí tại phòng phim như đầu đọc, đầu xem phim, hệ thống amply, máy chiếu, dàn karaoke... qua cổng hồng ngoại. Chỉ với 1 nút nhấn trong phần \"Ngữ cảnh\" là chủ nhà nhanh chóng bật tất cả các đầu máy dành cho việc xem phim hay karaoke theo nhu cầu."},
                    new Faq { Id = 20, Question = "Theo tôi biết nhà thông minh có 2 hệ thống là có dây và không dây. Hệ thống không dây thì phải phát qua sóng Zigbee để truyền tín hiệu. Vậy sinh hoạt trong nhà có sóng Zigbee truyền suốt ngày thì có ", Anwser = "Đúng là nhà thông minh không dây sẽ sử dụng sóng Radio không dây để truyền tín hiệu như Zigbee, Z-Wave. Về vấn đề sức khỏe, hiện tại chưa có bất kỳ nghiên cứu nào cho thấy sóng Zigbee gây hại cho sức khỏe. Ngoài ra cường độ của sóng Zigbee rất nhỏ so với các sóng điện từ thông thường nên chủ nhà có thể phần nào yên tâm về vấn đề sức khỏe"}
                };

                context.Faqs.AddRange(faqs);
                context.SaveChanges();
            }

            if(!context.Recruitments.Any()) {
                var recruitments = new Recruit[] {
                    new Recruit { Id = 4, Title ="Tuyển Dụng Trưởng Phòng Quản Lý Kỹ Thuật", Slug ="tuyen-dung-truong-phong-quan-ly-ky-thuat", Description = "Etron tuyển dụng Trưởng phòng quản lý đội kỹ thuật với 3 năm kinh nghiệm làm công tác quản lý các công trình xây dựng", Image ="etron-tuyen-dung-quan-ly.png", DateCreated = DateTime.Parse("2017-09-29 03:11:56")},
                    new Recruit { Id = 5, Title ="Tuyển Dụng Kỹ Sư Thiết Kế", Slug ="tuyen-dung-ky-su-thiet-ke", Description = "Etron tuyển dụng Kỹ sư thiết kế hệ thống điện với 3 năm kinh nghiệm làm việc trong lĩnh vực thiết kế hệ thống điện công trình dân dụng", Image ="etron-tuyen-dung-thiet-ke.png", DateCreated = DateTime.Parse("2017-09-29 03:46:56")},
                    new Recruit { Id = 6, Title ="Tuyển Dụng Kỹ Thuật Điện - Điện Nhẹ", Slug ="tuyen-dung-ky-thuat-dien-dien-nhe", Description = "Etron Tuyển Dụng Thi Công Điện - Điện Nhẹ tối thiểu 2 năm kinh nghiệm", Image ="etron-tuyen-dung-ky-thuat.png", DateCreated = DateTime.Parse("2017-09-29 04:06:02")},
                    new Recruit { Id = 7, Title ="Kỹ Thuật Thi Công Hệ Thống Mạng ", Slug ="ky-thuat-thi-cong-he-thong-mang", Description = "Etron Tuyển Dụng Thi Công Hệ thống Camera với 2 năm kinh nghiệm. Tốt nghiệp Cao Đẳng", Image ="etron-tuyen-dung-ky-thuat-camera-04.png", DateCreated = DateTime.Parse("2017-10-02 22:37:33")},

                };

                context.Recruitments.AddRange(recruitments);
                context.SaveChanges();
            }
        }
    }
}