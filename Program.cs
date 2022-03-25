using static Functions.Functions;
using Static;

Print("--  SecureCloud Launcher --");
Print("SecureCloud has started!");
Print($"Version {Info.Version} {Info.Codename}");


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();