using Microsoft.EntityFrameworkCore;
using server.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. REGISTER SERVICES
builder.Services.AddControllers();
// These two lines are the "Classic" way for .NET 8
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(connectionString));

var app = builder.Build();

// 2. CONFIGURE PIPELINE
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // Generates the JSON
    app.UseSwaggerUI(); // Generates the UI at /swagger
}

// Keep this commented in Docker until you set up certificates
// app.UseHttpsRedirection(); 

app.MapControllers();
app.Run();