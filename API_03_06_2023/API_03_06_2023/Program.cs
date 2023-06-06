using API_03_06_2023.Models.Database;
using API_03_06_2023.Repositories.Abstraction;
using API_03_06_2023.Repositories.Implementation;
using API_03_06_2023.Services.Abstraction;
using API_03_06_2023.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services
builder.Services.AddScoped<IHutrowniaService, HurtowniaService>();

// Repositories
builder.Services.AddScoped<IHurtowniaRepo, HurtowniaRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//CORS
app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.Run();
