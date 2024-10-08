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
    public class EfAppointmentDal : IAppointmentDal
    {
        public void Add(Appointment entity)
        {
            //direk newlemek yerine usingle newliyoruz daha performanslı oluyor.(IDisposable pattern implementation of c#)
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }


        public void Delete(Appointment entity)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Appointment Get(Expression<Func<Appointment, bool>> filter)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                return context.Set<Appointment>().SingleOrDefault(filter);
            }
        }

        public List<Appointment> GetAll(Expression<Func<Appointment, bool>> filter = null)
        {
            using (KonsoloslukTakipContext context = new KonsoloslukTakipContext())
            {
                //arka planda tıpkı select*from appointments çalıştırır ve bizim için listeye çevirir.
                //context sayesinde konsoloslukcontextten set<entity> geliyor which is veri tabanı tablosuyla eşitlediğimiz burda onu alıp listeye çeiviriyoruz. context bu yüzden lazım
                return filter == null ? context.Set<Appointment>().ToList():context.Set<Appointment>().Where(filter).ToList();
            }
        }

        

        public void Update(Appointment entity)
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
