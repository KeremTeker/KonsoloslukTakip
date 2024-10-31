using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.DependencyResolvers.Autofac;

var builder = WebApplication.CreateBuilder(args);

// Autofac’i DI konteyneri olarak kullanmak için ekliyoruz.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Autofac modülünü ekliyoruz.
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new AutofacBusinessModule());
});

// IoC kayýtlarý buraya eklenir.
//IOC yerine autofac yapýcaz
//çünkü ilerde AOP kullanýcaz ve farklý bir api kullanýrsak tekrardan bu baðlantýlarý yapmamýz gerkir onun yerine bu kýsmý baþka bir yere taþýyacaðýz.
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
