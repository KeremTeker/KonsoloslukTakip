
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

            if (DateTime.Now.Hour==17)
            {
                return new ErrorDataResult<List<Appointment>>(Messages.MaintenanceTime);
            }
            //zaten success olduğu için true göndermiyoruz true default base.
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(), Messages.AppointmentsListed);

        }

        public IDataResult<List<Appointment>> GetAllByCategory(int id)
        {
            return new SuccessDataResult<List<Appointment>> (_appointmentDal.GetAll(p=>p.VisaCategoryId==id));
        }

        public IDataResult<List<Appointment>> GetAllByStatus(bool status)
        {
            return new SuccessDataResult<List<Appointment>> (_appointmentDal.GetAll(p=>p.Status==status));
        }

        public IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<AppointmentDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<AppointmentDetailDto>> (_appointmentDal.GetAppointmentDetails());
        }

        public IDataResult<Appointment> GetById(int id)
        {
            return new SuccessDataResult<Appointment> (_appointmentDal.Get(a=>a.AppointmentId == id));
        }
    }
}
