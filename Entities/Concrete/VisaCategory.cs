using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VisaCategory : IEntity
    {
        public int VisaCategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<VisaType> VisaTypes { get; set; }
    }
}
