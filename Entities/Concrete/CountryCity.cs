using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CountryCity : IEntity
    {
        public int CountryCityId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }

        public Country Country { get; set; }
        public City City { get; set; }

        public ICollection<Consulate> Consulates { get; set; }
    }
}
