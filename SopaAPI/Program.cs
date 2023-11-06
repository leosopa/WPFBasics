using Microsoft.EntityFrameworkCore;
using SopaAPI.Data;
using SopaAPI.Model;
using SopaAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SoapAPIDbContext>(optionsAction =>
    optionsAction.UseSqlServer(builder.Configuration.GetConnectionString("SoapAPIContext")));
builder.Services.AddScoped<IRepository<Department>, DepartmentRepository>();
builder.Services.AddScoped<IRepository<Position>, PositionRepository>();
builder.Services.AddScoped<IRepository<Salary>, SalaryRepository>();
builder.Services.AddScoped<IRepository<PersonDetails>, PersonDetailsRepository>();
builder.Services.AddScoped<IRepository<Salary>, SalaryRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(DepartmentService));
builder.Services.AddScoped(typeof(SalaryService));
builder.Services.AddScoped(typeof(PersonService));
builder.Services.AddScoped(typeof(PersonDetailsService));
builder.Services.AddScoped(typeof(PositionService));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
