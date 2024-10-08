using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VisaType : IEntity
    {
        public int VisaTypeId { get; set; }
        public int VisaCategoryId { get; set; }
        public string TypeName { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        public VisaCategory VisaCategory { get; set; }
    }
}
