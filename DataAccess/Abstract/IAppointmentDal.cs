﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAppointmentDal:IEntityRepository<Appointment>
    {
        //gerekli dtolar buraya yazılabilir burası buyüzden var direk Repositorye bağlamama sebeplerimizden biri de bu.

       List<AppointmentDetailDto> GetAppointmentDetails();
    }
}
