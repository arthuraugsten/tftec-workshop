using Microsoft.EntityFrameworkCore;
using Workshops.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("default"),
        optionsBuilder => optionsBuilder.EnableRetryOnFailure(2, TimeSpan.FromSeconds(2), null)
    )
);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

using var scope = app.Services.CreateScope();
await scope.ServiceProvider.GetRequiredService<DatabaseContext>().Database.MigrateAsync();

app.Run();
