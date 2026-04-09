using Entity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//Add MVC
builder.Services.AddControllersWithViews();


//Add DbContext
builder.Services.AddDbContext<StudentWebsiteDbContext>(Soumi =>
{
    Soumi.UseSqlServer(builder.Configuration.GetConnectionString("StudentWebCON"));
});

//Build app
var app = builder.Build();

//Middleware
app.UseRouting();

//MapController
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sou}/{action=Index}/{id?}");

//Run app
app.Run();
