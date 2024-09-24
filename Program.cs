using System.Reflection;
using System.Text.Json.Serialization;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.Extensions;
using Backend_Riwi_LinkUp.Interfaces;
using Backend_Riwi_LinkUp.Services;
using DotNetEnv;
using Linkup_ms.Interfaces;
using Linkup_ms.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


// Load environment variables from a .env file
Env.Load();

// Retrieve database connection details from environment variables
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

// Build the connection string for PostgreSQL
var DefaultConnection = $"Host={dbHost};Database={dbDatabaseName};Username={dbUser};Password={dbPassword};Port={dbPort};";

// Create a web application builder
var builder = WebApplication.CreateBuilder(args);

// Configure the Entity Framework Core to use PostgreSQL with the connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(DefaultConnection));

// Add MVC controllers and configure JSON settings
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        // Configure JSON serialization to ignore reference loops and null values
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    });

// Configure Cross-Origin Resource Sharing (CORS) to allow specific origins
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            // Specify allowed origins, headers, methods, and credentials
            // .SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost" || origin == "https://riwi-linkup.vercel.app")
            builder.WithOrigins("http://127.0.0.1:3000", "http://localhost:3000", "https://riwi-linkup.vercel.app")
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials();
        });
});

// Configure Swagger for API documentation
builder.Services.AddSwaggerGen(c =>
{
    // Define Swagger document with title and version
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Coders API", Version = "v1" });
    c.SwaggerDoc("v2", new OpenApiInfo { Title = "Coders API", Version = "v2" });
    c.SwaggerDoc("v3", new OpenApiInfo { Title = "Coders API", Version = "v3" });

    // Set up XML documentation file for Swagger
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

});

// Register services for dependency injection
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<ICoderService, CoderService>();

// Add support for API endpoint exploration
builder.Services.AddEndpointsApiExplorer();

// Add custom identity services
builder.Services.AddIdentityServices(builder.Configuration);

// Build the web application
var app = builder.Build();

// Middleware de redirección HTTPS
app.UseHttpsRedirection();

// Enable Swagger UI middleware
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    // Define Swagger UI endpoint
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Version 1"); 
    c.SwaggerEndpoint("/swagger/v2/swagger.json", "Version 2");
    c.SwaggerEndpoint("/swagger/v3/swagger.json", "Version 3");
});


// Enable CORS policy
app.UseCors("AllowSpecificOrigin");
// Enable authentication middleware
app.UseAuthentication();
// Enable authorization middleware
app.UseAuthorization();
// Map API controllers to routes
app.MapControllers();

// Configure application to listen on a specified port or default to 5298
var port = Environment.GetEnvironmentVariable("PORT") ?? "5298";
app.Urls.Add($"http://0.0.0.0:{port}");

// Run the web application
app.Run();




