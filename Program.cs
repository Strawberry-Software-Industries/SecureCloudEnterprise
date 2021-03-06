using static Functions.Functions;
using Static;

var IsActivated = false;

Console.ForegroundColor = ConsoleColor.Green;
Print("--  SecureCloud Launcher --");
Console.ResetColor();
Print("SecureCloud was started!");
Print($"SecureCloud Version {Info.Version} {Info.Codename}");
Print("Enterprise 2022 - Evaluation License");

if (IsActivated == false)
{
    Print("Please activate SecureCloud");
}

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