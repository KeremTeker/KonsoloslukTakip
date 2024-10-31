using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //SingleInstance sayesinde tek bir instance üretip herkesle paylaşacak.
            builder.RegisterType<AppointmentManager>().As<IAppointmentService>().SingleInstance();
            builder.RegisterType<EfAppointmentDal>().As<IAppointmentDal>().SingleInstance();
        }
    }
}
