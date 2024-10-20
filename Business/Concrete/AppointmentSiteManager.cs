﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppointmentSiteManager : IAppointmentSiteService
    {
        IAppointmentSiteDal _appointmentSiteDal;

        public AppointmentSiteManager(IAppointmentSiteDal appointmentSiteDal)
        {
            _appointmentSiteDal = appointmentSiteDal;
        }

        public List<AppointmentSite> GetAll()
        {
            //iş kodları
            return _appointmentSiteDal.GetAll();

        }

        //Select * from AppointmentSites where AppointmentSiteId = 3
        public AppointmentSite GetById(int appointmentSiteId)
        {
            return _appointmentSiteDal.Get(a=>a.AppointmentSiteId == appointmentSiteId);
        }
    }
}
