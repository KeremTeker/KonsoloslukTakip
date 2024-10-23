
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.Inmemory;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        //void yerine IResult döndürüyoruz IResultın içinde isSucces ve Message var.
        public IResult Add(Appointment appointment)
        {
            //varsa iş kodları buraya yazılır ekleme öncesi

            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            if (appointment.AvailableDate>today)
            {
                return new ErrorResult("Gelecek tarih eklenemez");
            }

            _appointmentDal.Add(appointment);

            //methodun içinde döndürürken ctora iki adet parametre yolluyoruz. Bu yüzden resulta ctor eklememiz gerekiyor.
            //return new Result(true,"Ürün eklendi");

            //apiye gidecek response işi.
            return new SuccessResult("Ürün eklendi");
        }

        public List<Appointment> GetAll()
        {
            //iş kodları
            return _appointmentDal.GetAll();

        }

        public List<Appointment> GetAllByCategory(int id)
        {
            return _appointmentDal.GetAll(p=>p.VisaCategoryId==id);
        }

        public List<Appointment> GetAllByStatus(bool status)
        {
            return _appointmentDal.GetAll(p=>p.Status==status);
        }

        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            return _appointmentDal.GetAppointmentDetails();
        }

        public Appointment GetById(int id)
        {
            return _appointmentDal.Get(a=>a.AppointmentId == id);
        }
    }
}
