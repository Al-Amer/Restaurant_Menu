var builder = WebApplication.CreateBuilder(args);

var aooName = builder.Configuration["appName"];
var author = builder.Configuration["author"];
var greeting = builder.Configuration["Greeting"];
builder.Services.AddSingleton<TimeService>();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/info",()=> $"{greeting} \nThis application is called {aooName} \n  and is developed by {author}. \n Current time is: {app.Services.GetRequiredService<TimeService>().Now()}");
app.Run();


// TimService.cs
public class TimeService
{
    public string Now() => DateTime.Now.ToString("T");
}