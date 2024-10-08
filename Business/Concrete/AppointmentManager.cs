
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Inmemory;
using Entities.Concrete;
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
    }
}
