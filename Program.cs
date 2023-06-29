using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
//using env = Microsoft.AspNetCore.Hosting.IWebHostEnvironment;
using Paiol_EIBC;
using Paiol_EIBC.Repositories.Services;
using Rotativa.AspNetCore;
using ServiceStack.Text;
using Wkhtmltopdf.NetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("mystring")));
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<MaterialService>();
builder.Services.AddScoped<MaterialDanificadoService>();
builder.Services.AddScoped<CautelaService>();
builder.Services.AddScoped<CautelaDevolvidaService>();
builder.Services.AddWkhtmltopdf();





builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(options =>
{
options.ExpireTimeSpan= TimeSpan.FromHours(8);
options.SlidingExpiration = true;
options.AccessDeniedPath = new PathString("/Home");
options.LoginPath = new PathString("/Home");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

RotativaConfiguration.Setup(Path.Join("")); 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
