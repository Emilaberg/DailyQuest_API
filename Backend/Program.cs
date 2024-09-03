using Backend;
using Backend.MiddleWare;
using DataBase;
using DataBase.Repositories;
using DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared;
using Shared.DbModels;
using System.Globalization;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Default", policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
    });
});

builder.Services.AddSingleton<LocalFileReader>();
builder.Services.AddSingleton<PassKeyVerifier>();

// Retrieve the singleton instance of LocalFileReader
var reader = builder.Services.BuildServiceProvider().GetService<LocalFileReader>();
if (reader == null || reader.ReadJsonFile() == null) { throw new FileLoadException(); }

string? connectionString = reader.GetValue<string>("ConnectionString");
if (connectionString == null) throw new NullReferenceException();

Console.WriteLine("ConnectionString: " + connectionString);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString,
        b => b.MigrationsAssembly("Backend"))); // Specify the migrations assembly here


builder.Services.AddScoped<IGenericRepository<QuizModel>, QuizRepository>();
builder.Services.AddScoped<IGenericRepository<AnswerModel>, AnswerRepository>();
builder.Services.AddScoped<IGenericRepository<EmailModel>, EmailRepository>();
builder.Services.AddScoped<IGenericRepository<QuestionModel>, QuestionRepository>();
builder.Services.AddScoped<IGenericRepository<MetaTagModel>, MetaTagRepository>();






var app = builder.Build();
app.UseMiddleware<AdminPassKeyMiddleWare>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors("Default");

app.Run();


