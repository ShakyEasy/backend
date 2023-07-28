using Shaky_Easy.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ErrorHandlingMiddleware>();
var app = builder.Build();

// Configure the HTTP request pipeline.
{

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}