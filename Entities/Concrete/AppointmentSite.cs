using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AppointmentSite : IEntity
    {
        public int AppointmentSiteId { get; set; }
        public int CountryId { get; set; }
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }

        public Country Country { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
