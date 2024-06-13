using Microsoft.EntityFrameworkCore;
using SchoolDatabase.DBContext;
using SchoolDatabase.Mappings;
using SchoolDatabase.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DI
string? ConnStr=builder.Configuration.GetConnectionString("SchoolConnectionString");
builder.Services.AddDbContext<SchoolDBContext>(options=>options.UseSqlServer(ConnStr));
//repositories
builder.Services.AddScoped<IStudentRepository,SQLStudentRepository>();
//AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMappingProfiles));

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
