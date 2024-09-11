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
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
        { options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; });


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

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString,
        b => b.MigrationsAssembly("Backend").EnableRetryOnFailure())); // Specify the migrations assembly here


builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();
builder.Services.AddScoped<IEmailRepository, EmailRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IMetaTagRepository, MetaTagRepository>();
builder.Services.AddScoped<IQuizQuestionRepository, QuizQuestionRepository>();
builder.Services.AddScoped<IQuizRepository, QuizRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();





builder.Services.AddControllers();

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

app.UseCors("Default");

app.Run();

