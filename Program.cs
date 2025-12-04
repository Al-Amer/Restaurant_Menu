using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant_Menu.Seed;
using Restaurant_Menu.Data;

var builder = WebApplication.CreateBuilder(args);

// info path 
var aooName = builder.Configuration["appName"];
var author = builder.Configuration["author"];
var greeting = builder.Configuration["Greeting"];
builder.Services.AddSingleton<TimeService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    // http://localhost:5013/swagger/v1/swagger.json
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1"));
}

app.MapGet("/", () => Results.Ok("Restaurant API"));
app.MapGet("/info",()=> $"{greeting} \nThis application is called {aooName} \n  and is developed by {author}. \n Current time is: {app.Services.GetRequiredService<TimeService>().Now()}");



app.MapGet("/menu", (AppDbContext db) => 
{
    try
    {
        var menu = db.MenuItems.ToList();
        return Results.Ok(menu);
        
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message+ "\n"+ ex.StackTrace+ "\n"+ ex.InnerException +"\n"+ ex.Source + "\n"+ ex.Data+ "\n"+ ex.HelpLink+ "\n"+ ex.TargetSite+"\n ====  a big problem occurred  ====");
    }
    // return db.MenuItems.Select(mi => new 
    // {
    //     mi.Id,
    //     mi.Name,
    //     mi.Category,
    //     mi.Description,
    //     mi.Price
    // }).ToList();
});


app.Run();

// TimService.cs
public class TimeService
{
    public string Now() => DateTime.Now.ToString("T");
}