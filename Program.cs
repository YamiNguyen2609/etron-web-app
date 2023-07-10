using AppWebCore;
using Microsoft.AspNetCore.Rewrite;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

DbInitializer.Initialize(new EtronContext());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// app.UseAuthentication();

app.MapRazorPages();

var rewrite = new RewriteOptions()
               .AddRewrite("cong-trinh", "Project", true)
               .AddRewrite("dang-nhap", "Manager/Login", true)
               .AddRewrite("giai-phap", "Solution", true)
               .AddRewrite("gioi-thieu", "Overview", true)
               .AddRewrite("hoi-dap", "Faq", true)
               .AddRewrite("lien-he-thanh-cong", "Contact/Success", true)
               .AddRewrite("lien-he", "Contact", true)
               .AddRewrite("quan-ly-he-thong", "/Manager", true)
               .AddRewrite("quan-ly-loai-san-pham", "Manager/ProductType", true)
               .AddRewrite("quan-ly-san-pham", "Manager/Product", true)
               .AddRewrite("san-pham", "Product", true)
               .AddRewrite(@"trai-nghiem/(\w+-?\w+)", "Experience/Detail?name=$1", true)
               .AddRewrite("trai-nghiem", "Experience", true)
               .AddRewrite("tuyen-dung", "Recruit", true)
               .AddRewrite("trang-chu", "/", true);
app.UseRewriter(rewrite);

app.Run();
