var builder = WebApplication.CreateBuilder(args);

//var isActiveRazorPages = true;

var mvcBuilder = builder.Services.AddControllersWithViews();

if (builder.Environment.IsDevelopment())
    mvcBuilder.AddRazorRuntimeCompilation();

//if (isActiveRazorPages)
//    builder.Services.AddRazorPages();

//builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();