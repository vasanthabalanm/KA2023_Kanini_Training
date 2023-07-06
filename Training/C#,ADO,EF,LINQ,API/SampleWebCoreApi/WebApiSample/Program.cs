global using WebApiSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiSample.Data;
using WebApiSample.services.StudentService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentService, StudentService>();
//appsetting .json in connstr connection
//builder.Services.AddDbContext<StudentDataContxt>();
builder.Services.AddDbContext<StudentDataContxt>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "colg")));
builder.Services.AddCors(option => 
{
    option.AddPolicy("Stucorspolicy", builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("Stucorspolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
