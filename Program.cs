var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //adding service to provide routing to controllers and views\
var app = builder.Build();

//route convention
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
//app.MapGet("/", () => "Hello World!");

app.Run();
