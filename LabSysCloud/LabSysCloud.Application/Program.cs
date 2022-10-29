using Microsoft.AspNetCore.Rewrite;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1",new OpenApiInfo
{
    Title = "LabSysCloud API",
        Version = "v1",
        Description = "API do sistema LabSysCloud, desenvolvido na disciplina de C#",
        Contact = new OpenApiContact() { Name = "Wise Hands", Email = "atendimento@wisehands.org", Url = new Uri("https://wisehands.app/")}
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "LabSysCloud");
        options.RoutePrefix = string.Empty; 
    });
}
var option = new RewriteOptions();
option.AddRedirect("^$", "swagger");

app.UseRewriter(option);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
