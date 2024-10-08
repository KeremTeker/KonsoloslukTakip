using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ScrapeLog : IEntity
    {
        public int ScrapeLogId { get; set; }
        public int AppointmentId { get; set; }
        public DateTime ScrapeDate { get; set; }
        public bool Result { get; set; }

        public Appointment Appointment { get; set; }
    }
}
