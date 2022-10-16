using Microsoft.EntityFrameworkCore;
using PushCart.API.Data;
using PushCart.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", opt => opt.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

builder.Services.AddDbContext<PushCartDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

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

app.MapGet("/pushcart", async (PushCartDbContext db) =>

    await db.Cart.ToListAsync()
);
app.MapGet("/pushcart/pickedup", async (PushCartDbContext db) =>

    await db.Cart.Where(p => p.IsPickedUp).ToListAsync()
);
app.MapGet("/pushcart/{id}", async (int id, PushCartDbContext db) =>

    await db.Cart.FindAsync(id)
        is Cart cart ? Results.Ok(cart) : Results.NotFound()
);


app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}