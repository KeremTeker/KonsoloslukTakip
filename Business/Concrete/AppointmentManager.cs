
using Business.Abstract;
using Business.Constants;
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
                //"randevu ratihi geçersiz" bu şekilde yapmak yerine magic string kullanıyoruz çünkü bu mesajlar heryerde olacak hem ilerde değiştirirken kolay olacak hemde mesajlarımız standartize olacak.
                return new ErrorResult(Messages.AppointmentDateInvalid);
            }

            _appointmentDal.Add(appointment);

            //methodun içinde döndürürken ctora iki adet parametre yolluyoruz. Bu yüzden resulta ctor eklememiz gerekiyor.
            //return new Result(true,"Ürün eklendi");

            //apiye gidecek response işi.
            return new SuccessResult(Messages.AppointmentAdded);
        }

        //public List<Appointment> GetAll()
        //{
        //    //iş kodları
        //    return _appointmentDal.GetAll();

        //}

        public IDataResult<List<Appointment>> GetAll()
        {
            //iş kodları

            if (DateTime.Now.Hour==2)
            {
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(),true, "Randevular listelendi");

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
