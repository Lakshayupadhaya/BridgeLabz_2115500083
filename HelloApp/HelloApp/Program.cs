//This creates a web application.
using BusinessLayer.Service;
using RepositoryLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//AddControllers() tells the app that it will have API controllers (files that handle HTTP requests).
builder.Services.AddControllers();
builder.Services.AddScoped<RegisterHelloBL>();//Adding registerhellobl class 
builder.Services.AddScoped<RegisterHelloRL>();// Addind RegisterHelloRl class

var app = builder.Build();

// Configure the HTTP request pipeline.

//Middleware must be before app.Run()

//This forces all requests to use HTTPS instead of HTTP for security.
app.UseHttpsRedirection();

//This adds Authorization (but doesn't set up Authentication yet).
app.UseAuthorization();

//This tells the app, "Listen for incoming requests and send them to the right controller."
app.MapControllers();

//Starts the web server and listens for requests.
app.Run();
