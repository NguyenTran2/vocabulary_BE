using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Services;
using VocabularyProject.Models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add Entity

builder.Services.AddDbContext<VocabularyDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("VocabularyConnection"));
});

//Add DI

builder.Services.AddScoped<IWord, WordService>();
builder.Services.AddScoped<ICourse, CourseService>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<ILearnedDate, LearnedDateService>();
builder.Services.AddScoped<IFolder, FolderService>();

//allow CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("*"
                                              //"http://localhost:3000"
                                              ).AllowAnyMethod().AllowAnyHeader();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();