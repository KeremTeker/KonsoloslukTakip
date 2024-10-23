using Entities.Concrete;
using Entities.DTO_s;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        List<Appointment> GetAllByCategory(int id);
        List<Appointment> GetAllByStatus(bool status);
        List<AppointmentDetailDto> GetAppointmentDetails();

        //void yerine IResult döndürüyoruz IResultın içinde isSucces ve Message var.
        IResult Add(Appointment appointment);
        Appointment GetById(int id);
    }
}
