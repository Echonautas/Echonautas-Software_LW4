using Microsoft.EntityFrameworkCore;
using Software.Design.DataModels;
using Software.Design.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options =>
    options
        .UseNpgsql("Host=rok-bri-iskfu19.postgres.database.azure.com;Database=postgres;Username=Admin123;Password=4K$BUQF4FksVfd")
        .UseSnakeCaseNamingConvention());

builder.Services.AddScoped<My_Services>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

