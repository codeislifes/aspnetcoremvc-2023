var builder = WebApplication.CreateBuilder(args);

//var isActiveRazorPages = true;

builder.Services.AddControllersWithViews();

//if (isActiveRazorPages)
//    builder.Services.AddRazorPages();

//builder.Services.AddMvc();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "codeislife",
//    defaults: new { controller ="Home", action= "Index" });

app.Run();
