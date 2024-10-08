using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Consulate : IEntity
    {
        public int ConsulateId { get; set; }
        public int CountryCityId { get; set; }
        public string ConsulateName { get; set; }

        public CountryCity CountryCity { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
