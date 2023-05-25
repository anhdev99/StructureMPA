using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using Modules.Account.Extensions;
using Modules.FileManager.Extensions;
using Modules.Shared.Extensions;
using StructureMPA.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();;

#region Register Libs
builder.Services.AddAccountModule();
builder.Services.AddFileManagerModule();
builder.Services.AddSharedInfrastructure();
#endregion


builder.Services.Configure<RazorViewEngineOptions>(options => {
    options.ViewLocationExpanders.Add(new AreaViewLocationExpander());
});
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "StructureMPA.WebAPI", Version = "v1" });
});

builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StructureMPA.WebAPI v1")); 
}

app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = context =>
    {
        var headers = context.Context.Response.Headers;
        var contentType = headers["Content-Type"];
        if (contentType == "application/x-gzip")
        {
            if (context.File.Name.EndsWith("js.gz"))
            {
                contentType = "application/javascript";
            }
            else if (context.File.Name.EndsWith("css.gz"))
            {
                contentType = "text/css";
            }

            headers.Add("Content-Encoding", "gzip");
            headers["Content-Type"] = contentType;
        }
    }
});

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new CompositeFileProvider
    (
        new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Areas/Modules.Account/wwwroot")),
        new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Areas/Modules.FileManager/wwwroot"))
    )
});

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areaRoute",
    pattern:  "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.Run();
