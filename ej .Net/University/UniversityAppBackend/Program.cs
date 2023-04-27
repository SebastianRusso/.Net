
//1. use framework

using Microsoft.EntityFrameworkCore;
using UniversityAppBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//2. conenction

const string CONNECTIONNAME = "UniversityDB";
var conenctionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. add contex to servis of builder

builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(conenctionString));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
