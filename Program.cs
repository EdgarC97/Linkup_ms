using System.Text.Json.Serialization;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.Extensions;
using Backend_Riwi_LinkUp.Interfaces;
using Backend_Riwi_LinkUp.Services;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


Env.Load();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var DefaultConnection = $"Host={dbHost};Database={dbDatabaseName};Username={dbUser};Password={dbPassword};Port={dbPort};";


var builder = WebApplication.CreateBuilder(args);

// Configurar database para usar desarrollo
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(DefaultConnection));

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    });

// Configurar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            // .SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost" || origin == "https://riwi-linkup.vercel.app")
            builder.WithOrigins("http://127.0.0.1:3000", "http://localhost:3000", "https://riwi-linkup.vercel.app")
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials();
        });
});

// Configura Swagger para manejar JSON Patch
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Coders API", Version = "v1" });

    // Configura Swagger para usar NewtonsoftJson
    c.OperationFilter<SwaggerJsonPatchOperationFilter>();
});
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

// app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Use the PORT environment variable provided by Railway
var port = Environment.GetEnvironmentVariable("PORT") ?? "5298";
app.Urls.Add($"http://0.0.0.0:{port}");

app.Run();


// Clase auxiliar para configurar Swagger para JSON Patch
public class SwaggerJsonPatchOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (operation.RequestBody?.Content.Any(x => x.Key.ToLower().Contains("json-patch+json")) == true)
        {
            operation.RequestBody.Content["application/json-patch+json"].Schema = new OpenApiSchema
            {
                Type = "array",
                Items = new OpenApiSchema
                {
                    Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "Operation" }
                }
            };
        }
    }
}