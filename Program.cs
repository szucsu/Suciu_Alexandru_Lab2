using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Suciu_Alexandru_Lab2.Areas.Identity.Data;
using Suciu_Alexandru_Lab2.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<Suciu_Alexandru_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Suciu_Alexandru_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Suciu_Alexandru_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Suciu_Alexandru_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Suciu_Alexandru_Lab2Context' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
