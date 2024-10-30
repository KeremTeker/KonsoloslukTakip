using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;

var builder = WebApplication.CreateBuilder(args);

// IoC kay�tlar� buraya eklenir.
//IOC yerine autofac yap�caz
//��nk� ilerde AOP kullan�caz
builder.Services.AddSingleton<IAppointmentService, AppointmentManager>();
builder.Services.AddSingleton<IAppointmentDal, EfAppointmentDal>();

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
