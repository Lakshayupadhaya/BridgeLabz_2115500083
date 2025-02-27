using BusinessLayer;
using RepositoryLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<UserRegistrationBL>();//Adding business class for the reference/object in controller class
builder.Services.AddScoped<UserRegistrationRL>();//Adding repository class for the reference/object in Business class 

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
