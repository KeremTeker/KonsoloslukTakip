using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Appointment:IEntity
    {
        public int AppointmentId { get; set; }
        public int ConsulateId { get; set; }
        public int VisaCategoryId { get; set; }
        public int VisaTypeId { get; set; }
        public int AppointmentSiteId { get; set; }
        public DateOnly AvailableDate { get; set; }
        public bool Status { get; set; }
        public DateTime LastUpdateDate { get; set; }

        // Navigation properties
        public Consulate Consulate { get; set; }
        public VisaCategory VisaCategory { get; set; }
        public VisaType VisaType { get; set; }
        public AppointmentSite AppointmentSite { get; set; }

        public ICollection<Notification> Notifications { get; set; }
        public ICollection<ScrapeLog> ScrapeLogs { get; set; }
    }

}
