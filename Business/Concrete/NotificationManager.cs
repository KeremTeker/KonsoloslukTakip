using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;
        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }
        public IResult Add(Notification notification)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Notification>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Notification> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
