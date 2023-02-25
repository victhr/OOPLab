using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.IdentityModel.Tokens;
using MinimalAPIBased.Interfaces;
using MinimalAPIBased.Models;
using MinimalAPIBased.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITokenService, TokenService>();
builder.Services.AddSingleton<IUserRepositoryService, UserRepositoryService>();


//Authentication

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/testget", (Func<string>)(() => "This is a GET implementation Minimal API based"));

app.MapPost("/login", [AllowAnonymous] async(UserModel user, HttpContext http, ITokenService tokenservice, IUserRepositoryService useRepositoryService) =>
{
    var userModel = user;
    var userDto = useRepositoryService.GetUser(userModel);

    if (userDto == null)
    {
        http.Response.StatusCode = 401;
    }

    var token = tokenservice.BuildToken(builder.Configuration["Jwt:Key"], builder.Configuration["Jwt:Issuer"], userDto);

    await http.Response.WriteAsJsonAsync(new { token = token });
    return;

});

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}