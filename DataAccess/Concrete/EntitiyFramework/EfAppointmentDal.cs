using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfAppointmentDal : EfEntityRepositoryBase<Appointment, KonsoloslukTakipContext>, IAppointmentDal
    {
        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            //join yazıyoruz
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                var result = from a in context.Appointments
                             join vc in context.VisaCategories
                                on a.VisaCategoryId equals vc.VisaCategoryId
                             join vt in context.VisaTypes
                                on a.VisaTypeId equals vt.VisaTypeId
                             join co in context.Consulates
                                on a.ConsulateId equals co.ConsulateId
                             select new AppointmentDetailDto
                             {
                                 CategoryName = vc.CategoryName,
                                 TypeName = vt.TypeName,
                                 ConsulateName = co.ConsulateName,
                                 AvailableDate = a.AvailableDate,
                                 Status = a.Status,
                                 LastUpdateDate = a.LastUpdateDate
                             };

                return result.ToList();

            }        
        }
    }
}
