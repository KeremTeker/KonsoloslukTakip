using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountryCityService
    {
        IDataResult<List<CountryCity>> GetAll();
        IResult Add(CountryCity countryCity);
        IDataResult<CountryCity> GetById(int id);
        IResult Update(CountryCity countryCity);
    }
}
