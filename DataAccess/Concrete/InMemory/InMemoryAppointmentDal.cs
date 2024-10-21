using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Inmemory
{
    public class InMemoryAppointmentDal : IAppointmentDal
    {
        List<Appointment> _appointments;
        public InMemoryAppointmentDal()
        {
            _appointments = new List<Appointment> {
                new Appointment{AppointmentId = 1, ConsulateId=1, VisaCategoryId=1, VisaTypeId=1, AppointmentSiteId=1, AvailableDate = new DateOnly(2024,09,26), 
                    Status= true , LastUpdateDate= new DateTime (2024,09,26,21,35,0) },
                new Appointment{AppointmentId = 2, ConsulateId=1, VisaCategoryId=1, VisaTypeId=1, AppointmentSiteId=1, AvailableDate = new DateOnly(2024,09,26),
                    Status= true , LastUpdateDate= new DateTime (2024,09,26,21,35,0) },
                new Appointment{AppointmentId = 3, ConsulateId=1, VisaCategoryId=1, VisaTypeId=1, AppointmentSiteId=1, AvailableDate = new DateOnly(2024,09,26),
                    Status= true , LastUpdateDate= new DateTime (2024,09,26,21,35,0) },
                new Appointment{AppointmentId = 4, ConsulateId=1, VisaCategoryId=1, VisaTypeId=1, AppointmentSiteId=1, AvailableDate = new DateOnly(2024,09,26),
                    Status= true , LastUpdateDate= new DateTime (2024,09,26,21,35,0) }

            }; 
        }
        public void Add(Appointment appointment)
        {
            _appointments.Add(appointment);
        }

        public void Delete(Appointment appointment)
        {
            

            Appointment appointmentToDelete = _appointments.SingleOrDefault(a => a.AppointmentId == appointment.AppointmentId);
            _appointments.Remove(appointmentToDelete);
        }

        public Appointment Get(Expression<Func<Appointment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            return _appointments;
        }

        public List<Appointment> GetAll(Expression<Func<Appointment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetByConsulate(int consulateId)
        {
            return _appointments.Where(a=>a.ConsulateId == consulateId).ToList();
        }

        public void Update(Appointment appointment)
        {
            Appointment appointmentToUpdate = _appointments.SingleOrDefault(a => a.AppointmentId == appointment.AppointmentId);
            appointmentToUpdate.AppointmentId = appointment.AppointmentId;
            appointmentToUpdate.ConsulateId = appointment.ConsulateId;
            appointmentToUpdate.VisaCategoryId = appointment.VisaCategoryId;
            appointmentToUpdate.VisaTypeId = appointment.VisaTypeId;
            appointmentToUpdate.AppointmentSiteId = appointment.AppointmentSiteId;
            appointmentToUpdate.AvailableDate = appointment.AvailableDate;
            appointmentToUpdate.Status = appointment.Status;
            appointmentToUpdate.LastUpdateDate = appointment.LastUpdateDate;

        }
    }
}
