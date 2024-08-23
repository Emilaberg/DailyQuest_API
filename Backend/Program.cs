using DataBase;
using DataBase.Repositories;
using DataBase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DbModels;

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


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IGenericRepository<QuizModel>, QuizRepository>();
builder.Services.AddScoped<IGenericRepository<QuestionMetaTag>, QuestionMetaTagRepository>();
builder.Services.AddScoped<IGenericRepository<AnswerModel>, AnswerRepository>();
builder.Services.AddScoped<IGenericRepository<EmailModel>, EmailRepository>();
builder.Services.AddScoped<IGenericRepository<QuestionModel>, QuestionRepository>();
builder.Services.AddScoped<IGenericRepository<MetaTagModel>, MetaTagRepository>();




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


