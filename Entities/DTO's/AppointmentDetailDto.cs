using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO_s
{
    //contexte eklemesin diye IEntity vermiyoruz çünkü bir değil birden fazla tabloya karşılık gelecek.
    public class AppointmentDetailDto:IDto
    {
        public string CategoryName { get; set; }
        public string TypeName { get; set; }
        public string ConsulateName { get; set; }
        public DateOnly AvailableDate { get; set; }
        public bool Status { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
