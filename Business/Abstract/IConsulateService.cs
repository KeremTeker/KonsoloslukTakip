using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IConsulateService
    {
        IDataResult<List<Consulate>> GetAll();
        IResult Add(Consulate consulate);
        IDataResult<Consulate> GetById(int id);
        IResult Update(Consulate consulate);
    }
}
