using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppointmentSiteService
    {
        IDataResult<List<AppointmentSite>> GetAll();
        IResult Add(AppointmentSite appointmentSite);
        IDataResult<AppointmentSite> GetById(int id);
        IResult Update(AppointmentSite appointmentSite);
    }
}
