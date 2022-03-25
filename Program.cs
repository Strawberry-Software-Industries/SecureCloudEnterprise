using static Functions.Functions;
using Static;

Console.ForegroundColor = ConsoleColor.Green;
Print("--  SecureCloud Launcher --");
Console.ResetColor();
Print("SecureCloud has started!");
Print($"Version {Info.Version} {Info.Codename}");
Print("");


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