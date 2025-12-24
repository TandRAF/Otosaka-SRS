using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Interfaces;
using server.Repositories;
using server.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. REGISTER SERVICES
builder.Services.AddControllers();
// These two lines are the "Classic" way for .NET 8
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 
// Professional way to register AutoMapper
builder.Services.AddAutoMapper(typeof(server.Profiles.MappingProfiles));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(connectionString));
builder.Services.AddScoped<INoteRepository, NoteRepository>();
builder.Services.AddScoped<INoteService, NoteService>();
var app = builder.Build();

// 2. CONFIGURE PIPELINE
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // Generates the JSON
    app.UseSwaggerUI(); // Generates the UI at /swagger
}

// Keep this commented in Docker until you set up certificates
// app.UseHttpsRedirection(); 

// Inside Program.cs
var logger = app.Services.GetRequiredService<ILogger<Program>>();

using (var scope = app.Services.CreateScope())
{
    try 
    {
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var pendingMigrations = await context.Database.GetPendingMigrationsAsync();
        
        if (pendingMigrations.Any())
        {
            logger.LogInformation("Applying {Count} pending migrations...", pendingMigrations.Count());
            await context.Database.MigrateAsync();
            logger.LogInformation("Database is up to date.");
        }
    }
    catch (Exception ex)
    {
        logger.LogCritical(ex, "Database migration failed. The application cannot start.");
        throw; // Kill the app so you know there's a major problem
    }
}

app.MapControllers();
app.Run();