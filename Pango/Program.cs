using MediatR;
using Microsoft.EntityFrameworkCore;
using Pango.Application.Common.Mapping;
using Pango.Domain.Interfaces;
using Pango.Infrastructure;
using Pango.Infrastructure.Repositories;
using Pango.Presentation.Models.Mappers;

var builder = WebApplication.CreateBuilder(args);


var presentationAssembly = typeof(Pango.Presentation.AssemblyReference).Assembly;
var applicationAssembly = typeof(Pango.Application.AssemblyReference).Assembly;

builder.Services.AddControllers().AddApplicationPart(presentationAssembly);
builder.Services.AddMediatR(applicationAssembly);

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PangoContext>(options =>
{
    options.UseSqlServer(builder.Configuration[Pango.Domain.Constants.CEToolsConnection]);
});
builder.Services.AddAutoMapper(typeof(Program), typeof(MappingProfile));

builder.Services.AddScoped<DbContext, PangoContext>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IParkingRepository, ParkingRepository>();
builder.Services.AddScoped<IParkingZoneRepository, ParkingZoneRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();

builder.Services.AddScoped<IApiMapper, ApiMapper>();

var app = builder.Build();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

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

public partial class Program { }
