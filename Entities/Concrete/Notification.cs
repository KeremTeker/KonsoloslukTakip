using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Notification : IEntity
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public int AppointmentId { get; set; }
        public string NotificationType { get; set; }

        public User User { get; set; }
        public Appointment Appointment { get; set; }

    }
}
