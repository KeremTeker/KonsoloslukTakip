﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INotificationService
    {
        IDataResult<List<Notification>> GetAll();
        IResult Add(Notification notification);
        IDataResult<Notification> GetById(int id);
        IResult Update(Notification notification);
    }
}
