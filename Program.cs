using Entity1;
using Microsoft.EntityFrameworkCore;
using Service;
using ServiceContracts;


var builder = WebApplication.CreateBuilder(args);

//Add MVC
builder.Services.AddControllersWithViews();


//Add DbContext
builder.Services.AddScoped<IStdService, StdService>();

builder.Services.AddDbContext<StudentWebsiteDbContext>(Soumi =>
{
    Soumi.UseSqlServer(builder.Configuration.GetConnectionString("StudentWebCON"));
});

//Build app
var app = builder.Build();

app.UseStaticFiles();

//Middleware
app.UseRouting();

//MapController
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Std}/{action=ShowStdData}/{id?}");

//Run app
app.Run();
