var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// Get value from general
//app.MapGet("/", (HttpContext context) =>
//{
//    string path = context.Request.Path;
//    string method = context.Request.Method;

//    context.Response.StatusCode = 404;

//    return "Request path: " + path + " Http Method: " + method;
//});

// Get the value from request header, header is a dictionary
//app.MapGet("/", (HttpContext context) =>
//{
//    var Accept = "";
//    if (context.Request.Headers.ContainsKey("Accept"))
//    {
//        Accept = context.Request.Headers["Accept"];
//    }
//    return Accept;
//});

//Set value to response header
//app.MapGet("/", (HttpContext context) =>
//{
//    return "This is a response";

//    context.Response.Headers["Content-Type"] = "text/html";
//    return "<h2>This is a response</h2>";

//     Set customer header
//    context.Response.Headers["MyHeader"] = "Hello";
//    return "This is a response";
//});

// Status Code
//app.Run(async (HttpContext context) =>
//{
//    //await context.Response.WriteAsync("Hello World!");


//    string path = context.Request.Path;
//    if (path == "/" || path == "/Home")
//    {
//        context.Response.StatusCode = 200;
//        await context.Response.WriteAsync("This is Home page!");
//    }
//    else if (path == "/Product")
//    {
//        context.Response.StatusCode = 200;
//        await context.Response.WriteAsync("This is Product page!");
//    }
//    else
//    {
//        context.Response.StatusCode = 404;
//        await context.Response.WriteAsync("This page is not found!");
//    }

//});

// Http request method - GET, POST, PUT, PATCH, DELETE
//app.Run(async (HttpContext context) =>
//{
//    string path = context.Request.Path;
//    string method = context.Request.Method;
//    if (path == "/" || path == "/Home")
//    {
//        context.Response.StatusCode = 200;
//        await context.Response.WriteAsync("This is Home page!");
//    }
//    else if (method == "GET" && path == "/Product")
//    {
//        context.Response.StatusCode = 200;

//        if (context.Request.Query.ContainsKey("id") && context.Request.Query.ContainsKey("name"))
//        {
//            string id = context.Request.Query["id"];
//            string name = context.Request.Query["name"];
//            await context.Response.WriteAsync("ID is:" + id + " Name is:" + name);
//            return;
//        }

//        await context.Response.WriteAsync("This is Product page!");

//    }
//    else if (method == "POST" && path == "/Product")
//    {
//        StreamReader reader = new StreamReader(context.Request.Body);
//        string data = await reader.ReadToEndAsync();
//        await context.Response.WriteAsync("Data is:" + data);
//    }
//    else
//    {
//        context.Response.StatusCode = 404;
//        await context.Response.WriteAsync("This page is not found!");
//    }

//});

app.Run();
