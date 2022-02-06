var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AgenciaCronos.Models.CronosContext>();

var app = builder.Build();

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
    name: "Post",
    pattern: "{controller=Posts}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "Integrante",
    pattern: "{controller=Integrantes}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Servico",
    pattern: "{controller=Servicos}/{action=Index}/{id?}");

app.Run();
