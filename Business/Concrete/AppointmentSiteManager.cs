using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
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

        public IResult Add(AppointmentSite appointmentSite)
        {
           IResult result = BusinessRules.Run(CheckIfAppointmentSiteNameExists(appointmentSite.SiteName),
                CheckIfAppointmentSiteUrlExists(appointmentSite.SiteUrl));

            if (result != null)
            {
                return result;
            }
            _appointmentSiteDal.Add(appointmentSite);
            return new SuccessResult(Messages.AppointmentSiteAdded);


            //if (CheckIfAppointmentSiteNameExists(appointmentSite.SiteName).Success)
            //{
            //    if (CheckIfAppointmentSiteUrlExists(appointmentSite.SiteUrl).Success)
            //    {
            //        _appointmentSiteDal.Add(appointmentSite);
            //        return new SuccessResult(Messages.AppointmentSiteAdded);
            //    }
            //    return new ErrorResult(Messages.SiteUrlExistsError);
            //}
            //return new ErrorResult(Messages.CityNameExistsError);
        }

        public IDataResult<List<AppointmentSite>> GetAll()
        {
            return new SuccessDataResult<List<AppointmentSite>>(_appointmentSiteDal.GetAll(), Messages.AppointmentSitesListed);
        }

        public IDataResult<AppointmentSite> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AppointmentSite appointmentSite)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfAppointmentSiteNameExists(string appointmentSiteName)
        {
            var existingSiteNames = _appointmentSiteDal.GetAll(a => a.SiteName == appointmentSiteName).Any();
            if (existingSiteNames == true)
            {
                return new ErrorResult(Messages.SiteNameExistsError);

            }
            return new SuccessResult();
        }
        private IResult CheckIfAppointmentSiteUrlExists(string appointmentSiteUrl)
        {
            var existingSiteUrl = _appointmentSiteDal.GetAll(a => a.SiteUrl == appointmentSiteUrl).Any();
            if (existingSiteUrl == true)
            {
                return new ErrorResult(Messages.SiteUrlExistsError);

            }
            return new SuccessResult();
        }

        //Select * from AppointmentSites where AppointmentSiteId = 3

    }
}
