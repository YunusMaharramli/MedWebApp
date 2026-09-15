using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using WebMedApp.Data;
using WebMedApp.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc(SwaggerDocumentNames.AdminV1, new OpenApiInfo
    {
        Title = "WebMedApp Admin API",
        Version = "v1",
        Description = "Administrative endpoints for WebMedApp."
    });

    options.SwaggerDoc(SwaggerDocumentNames.ClientV1, new OpenApiInfo
    {
        Title = "WebMedApp Client API",
        Version = "v1",
        Description = "Client-facing endpoints for WebMedApp."
    });

    options.DocInclusionPredicate((documentName, apiDescription) =>
        string.Equals(apiDescription.GroupName, documentName, StringComparison.OrdinalIgnoreCase));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
            $"/swagger/{SwaggerDocumentNames.ClientV1}/swagger.json",
            "Client API v1");
        options.SwaggerEndpoint(
            $"/swagger/{SwaggerDocumentNames.AdminV1}/swagger.json",
            "Admin API v1");
        options.DocumentTitle = "WebMedApp API Documentation";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
