using Business.Abstract;
using Business.Constants;
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
    public class CityManager : ICityService
    {

        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            if (CheckIfCityNameExsists(city.CityName).Success)
            {
                if (CheckIfCityCountExceedsLimit().Success)
                {
                    _cityDal.Add(city);
                    return new SuccessResult(Messages.CityAdded);
                }
                return new ErrorResult(Messages.CityCountExceedsLimitError);
            }
            return new ErrorResult(Messages.CityNameExistsError);
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), Messages.CitiesListed);
        }

        public IDataResult<City> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(City city)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfCityNameExsists(string cityName)
        {
            var existingCityNames = _cityDal.GetAll(c => c.CityName == cityName).Any();
            if (existingCityNames == true) 
            {
                return new ErrorResult(Messages.CityNameExistsError);

            }
            return new SuccessResult();
        }

        private IResult CheckIfCityCountExceedsLimit()
        {
            var cityCount = _cityDal.GetAll().Count();
            if (cityCount >= 81)
            {
                return new ErrorResult(Messages.CityCountExceedsLimitError);
            }
            return new SuccessResult();
        }

    }
}
