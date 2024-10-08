using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    internal class EfAppointmentSiteDal : IAppointmentSiteDal
    {
        public void Add(AppointmentSite entity)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(AppointmentSite entity)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public AppointmentSite Get(Expression<Func<AppointmentSite, bool>> filter)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                return context.Set<AppointmentSite>().SingleOrDefault(filter);
            }
        }

        public List<AppointmentSite> GetAll(Expression<Func<AppointmentSite, bool>> filter = null)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                return filter == null ? context.Set<AppointmentSite>().ToList() : context.Set<AppointmentSite>().Where(filter).ToList();
            }
        }

        public void Update(AppointmentSite entity)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
