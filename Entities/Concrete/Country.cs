using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Country : IEntity

    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public ICollection<CountryCity> CountryCities { get; set; }
        public ICollection<AppointmentSite> AppointmentSites { get; set; }
    }
}
