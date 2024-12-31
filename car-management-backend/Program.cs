using car_management_backend.Data;
using car_management_backend.Data.Repositories;
using car_management_backend.Data.Services;
using car_management_backend.Data.Services.Interfaces;
using car_management_backend.Services.Interfaces;
using car_management_backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); 
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(
        builder.Configuration
            .GetConnectionString("webApp1Database")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                      });
});

builder.Services.AddTransient<ICarRepo, CarRepo>();
builder.Services.AddTransient<IGarageRepo, GarageRepo>();
builder.Services.AddTransient<IMaintananceRepo, MaintananceRepo>();


builder.Services.AddTransient<ICarService, CarService>();
builder.Services.AddTransient<IGarageService, GarageService>();
builder.Services.AddTransient<IMaintananceService, MaintananceService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//http://localhost:3000/garages
app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
