using System.Text;
using BusinessLayer;
using BusinessLayer.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RepositoryLayer;
using RepositoryLayer.Context;
using RepositoryLayer.Helper;
using RepositoryLayer.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add Logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();  // Logs to Console
builder.Logging.AddDebug();    // Logs to Debug Output



//var app = builder.Build();

//// Resolve Logger Manually
//using (var scope = app.Services.CreateScope())
//{
//    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
//    logger.LogInformation("Application Started!");
//}

//app.Run();

// Add services to the container.



builder.Services.AddControllers();
builder.Services.AddScoped<IUserRergistrationBL, UserRegistrationBL>();
builder.Services.AddScoped<IUserRegistrationRL,UserRegistrationRL>();//object of class is created and passed to interface
builder.Services.AddSingleton<TokenHelper>();

//Adding authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer
    (options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,//We can also disable this by false and not give issuer in our token
            ValidateAudience = true,//We can also disable this by false and not give audience in our token
            ValidateLifetime = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

//Works with Dependency Injection (DI)

//builder.Services.AddDbContext<RegistrationAppContext>(options =>
//options.UseSqlServer("YourConnectionString"));
var connectionString = builder.Configuration.GetConnectionString("SqlConnection"); 
builder.Services.AddDbContext<
    RegistrationAppContext>(options =>
    options.UseSqlServer(connectionString));

// After this open package manager console ->
//Add-Migration InitialMigration
//Update-Database

// Add swagger to container
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();//using Swagger
    app.UseSwaggerUI();// responsible for colorfullness
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
