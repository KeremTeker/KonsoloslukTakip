using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.DependencyResolvers.Autofac;

var builder = WebApplication.CreateBuilder(args);

// Autofac�i DI konteyneri olarak kullanmak i�in ekliyoruz.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Autofac mod�l�n� ekliyoruz.
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new AutofacBusinessModule());
});

// IoC kay�tlar� buraya eklenir.
//IOC yerine autofac yap�caz
//��nk� ilerde AOP kullan�caz ve farkl� bir api kullan�rsak tekrardan bu ba�lant�lar� yapmam�z gerkir onun yerine bu k�sm� ba�ka bir yere ta��yaca��z.
//builder.Services.AddSingleton<IAppointmentService, AppointmentManager>();
//builder.Services.AddSingleton<IAppointmentDal, EfAppointmentDal>();

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
