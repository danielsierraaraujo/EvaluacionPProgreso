using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EvaluacionPProgreso.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar el contexto de base de datos
builder.Services.AddDbContext<DanielSierraDBEvaluacionPProgreso>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DanielSierraDBEvaluacionPProgreso")
        ?? throw new InvalidOperationException("Connection string 'DanielSierraDBEvaluacionPProgreso' not found."))
);

// Agregar servicios al contenedor
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar la canalización HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Seguridad HTTP Strict Transport Security
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
