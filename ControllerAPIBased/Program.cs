using ControllerAPIBased.Handlers;
using ControllerAPIBased.Requirements;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add services to container like DI

builder.Services.AddTransient<IAuthorizationHandler, ValidSessionHandler>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AuthorizationAPI", policy =>
    policy.Requirements.Add(new ValidSessionAuthorization()));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
