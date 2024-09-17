using Microsoft.AspNetCoreEmpty.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();


app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();

/* 
Controller: Gelen istekleri işler ve ilgili işlemi yaparak bir response döner. Örneğin HomeController, "/Home" adresine gelen istekleri karşılar.
Action: Controller içindeki her bir fonksiyona karşılık gelen işlevsel yapılardır. Örneğin, HomeController içindeki Index metodu bir action'dır.
Model: Veri tabanından veya başka kaynaklardan gelen veriyi temsil eden yapılardır. Örneğin, bir "Product" modeli, ürünlerle ilgili verileri taşır.
View: Kullanıcıya gösterilecek arayüzü temsil eden yapıdır. Genellikle Razor syntax'ı kullanılarak HTML çıktıları üretilir.
Razor: ASP.NET Core'da HTML ile C# kodlarını birleştirerek dinamik içerikler oluşturmamızı sağlayan bir tasarım dilidir.
RazorView: Bir view dosyasının (örneğin .cshtml) Razor motoru tarafından işlenerek HTML çıktısı haline getirilmesini sağlar.
wwwroot: Projeye ait statik dosyaların (CSS, JS, resim dosyaları vb.) tutulduğu dizindir.
builder.Build(): Uygulamanın ayarlarını yapılandıran ve çalıştırılmaya hazır hale getiren metottur.
app.Run(): Uygulamanın çalışmasını başlatan metottur ve HTTP isteklerinin dinlenmesini sağlar.
*/
