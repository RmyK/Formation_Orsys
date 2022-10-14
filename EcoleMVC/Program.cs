using EcoleBusiness.Services;
using EcoleBusiness.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

//using var ServicesScoped = builder.Services.
//var services = 

// Add services to the container.
builder.Services.AddControllersWithViews();
//if (builder.Environment.IsDevelopment())
//    builder.Services.AddScoped<IElevesService, EleveMockService>();
//else 
builder.Services.AddScoped<IElevesService, EleveService>();

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

app.Run();
