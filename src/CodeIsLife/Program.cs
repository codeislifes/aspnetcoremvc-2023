var builder = WebApplication.CreateBuilder(args);

//var isActiveRazorPages = true;

builder.Services.AddControllersWithViews();

//if (isActiveRazorPages)
//    builder.Services.AddRazorPages();

//builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();