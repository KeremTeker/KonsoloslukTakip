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
            //burada Appointment Managerin ctorundan ötürü bana bir product dal ver diyor bizde veriyoruz. Çünkü veriyi hangi veri verme yönteminden verecek bilmeli.
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());

            foreach (var appointment in appointmentManager.GetAllByStatus(false))
            {
                Console.WriteLine(appointment.AppointmentId);
            }


        }
    }
}