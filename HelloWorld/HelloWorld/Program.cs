var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();
app.MapGet("/home", () => "Hello");

app.Run();
