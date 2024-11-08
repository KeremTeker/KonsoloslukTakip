using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVisaCategoryService
    {
        IDataResult<List<VisaCategory>> GetAll();
        IResult Add(VisaCategory visaCategory);
        IDataResult<VisaCategory> GetById(int id);
        IResult Update(VisaCategory visaCategory);
    }
}
