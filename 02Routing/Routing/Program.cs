var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();

// Define routing
//app.UseEndpoints(endpoints =>
//{
//    // For any request method
//    endpoints.Map("/Home", async (HttpContext context) =>
//    {
//        await context.Response.WriteAsync("This is Home page!");
//    });

//    endpoints.MapGet("/Product", async (HttpContext context) =>
//    {
//        await context.Response.WriteAsync("This is Product page!");
//    });
//    endpoints.MapPost("/Product", async (HttpContext context) =>
//    {
//        await context.Response.WriteAsync("Post request in Product page!");
//    });
//});

////For all other routes
//app.Run(async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("The page is not found");
//});

// Route parameter
app.UseEndpoints(endpoints =>
{

    //endpoints.MapGet("/Product/{id}", async (HttpContext context) =>
    //{
    //   var id = Convert.ToInt32(context.Request.RouteValues["id"]);
    //   await context.Response.WriteAsync("ID is: " + id);

    //});



    // optional parameter
    //endpoints.MapGet("/Product/{id?}", async (HttpContext context) =>
    //{
    //    var id = context.Request.RouteValues["id"];
    //    if (id != null)
    //    {
    //        await context.Response.WriteAsync("ID is: " + id);
    //    }
    //    else
    //    {
    //        await context.Response.WriteAsync("This is product page!");
    //    }
    //});

    // default parameter
    //endpoints.MapGet("/Product/Detail/{name}/{id=1}", async (HttpContext context) =>
    //{
    //    var name = Convert.ToString(context.Request.RouteValues["name"]);
    //    var id = Convert.ToInt32(context.Request.RouteValues["id"]);
    //    await context.Response.WriteAsync($"Id is {id}, Name is {name}");
    //});

    // route constraint(int for integar, alpha for text)
    endpoints.MapGet("/Product/{name:alpha}", async (HttpContext context) =>
    {
        var name = context.Request.RouteValues["name"];
        await context.Response.WriteAsync("Name is: " + name);
    });
});

app.Run();
