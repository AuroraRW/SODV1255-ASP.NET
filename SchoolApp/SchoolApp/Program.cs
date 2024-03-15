using Microsoft.EntityFrameworkCore;
using SchoolApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolDbContext>(options =>
                            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));
var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

app.Run();
