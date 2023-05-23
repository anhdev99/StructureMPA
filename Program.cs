using Microsoft.AspNetCore.Mvc.Razor;
using Modules.Account.Extensions;
using Modules.Shared.Extensions;
using StructureMPA.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();;

builder.Services.AddAccountModule();

builder.Services.Configure<RazorViewEngineOptions>(options => {
    options.ViewLocationExpanders.Add(new AreaViewLocationExpander());
});

builder.Services.AddMvc();
var app = builder.Build();
// Add services to the container.
builder.Services.AddSharedInfrastructure(app.Configuration);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areaRoute",
    pattern:  "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.Run();
