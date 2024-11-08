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
        internal static string AppointmentCountofCategoryError = "Bu vize kategorisi için maksimum randevu sayısına ulaşıldı.";
        internal static string CityNameExistsError = "Bu şehir sistemde zaten bulunmaktadır.";
        internal static string CityAdded = "Şehir eklendi.";
        internal static string CitiesListed = "Şehirler Listelendi";
        internal static string AppointmentSitesListed = "Randevu Siteleri Listelendi.";
        internal static string SiteNameExistsError = "Bu site zaten mevcut";
        internal static string AppointmentSiteAdded = "Randevu Sitesi Eklendi.";
        internal static string SiteUrlExistsError = "Bu site linki zaten mevcut";
        internal static string CityCountExceedsLimitError = "Maximum şehir sayısına ulaşıldı.";
    }
}
