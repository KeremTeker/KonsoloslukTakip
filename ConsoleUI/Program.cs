using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.Inmemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //SOLID
    //OPEN CLOSED PRINCIPLE
    //IN MEMORYE HİÇ DOKUNMADIK SADECE EF EKLEDİK
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentTest();
            //AppointmentSiteTest();

        }

        private static void AppointmentSiteTest()
        {
            AppointmentSiteManager appointmentSiteManager = new AppointmentSiteManager(new EfAppointmentSiteDal());

            foreach (var appointmentsite in appointmentSiteManager.GetAll())
            {
                Console.WriteLine(appointmentsite.SiteName);
            }
        }

        private static void AppointmentTest()
        {
            //burada Appointment Managerin ctorundan ötürü bana bir product dal ver diyor bizde veriyoruz. Çünkü veriyi hangi veri verme yönteminden verecek bilmeli.
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());

            var result = appointmentManager.GetAppointmentDetails();


            //Successden true geliyorsa sadece datayı gösterecek false geliyorsa false un mesajını gösterecek.
            if (result.Success==true)
            {
                foreach (var appointment in result.Data)
                {
                    Console.WriteLine(appointment.CategoryName + "/" + appointment.TypeName + "/" + appointment.ConsulateName + "/" + appointment.AvailableDate + "/" + appointment.Status + "/" + appointment.LastUpdateDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}