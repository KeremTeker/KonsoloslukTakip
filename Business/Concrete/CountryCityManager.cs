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
    public class CountryCityManager : ICountryCityService
    {
        ICountryCityDal _countryCityDal;

        public CountryCityManager(ICountryCityDal countryCityDal)
        {
            _countryCityDal = countryCityDal;
        }
        public IResult Add(CountryCity countryCity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CountryCity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CountryCity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CountryCity countryCity)
        {
            throw new NotImplementedException();
        }
    }
}
