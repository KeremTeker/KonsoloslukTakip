using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Constants
{
    //mesajlar bu projeye özel olacağı için core a değil bussiness sabitlerine koyuyoruz.

    //newlemeyle uğraşmamak için static yapıyoruz.
    public static class Messages
    {
        public static string AppointmentAdded = "Randevu eklendi";
        public static string AppointmentDateInvalid = "Randevu tarihi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda" ;
        public static string AppointmentsListed = "Randevular Listelendi";
    }
}
