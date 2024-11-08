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
    public class ConsulateManager : IConsulateService
    {

        IConsulateDal _consulateDal;

        public ConsulateManager(IConsulateDal consulateDal)
        {
            _consulateDal = consulateDal;
        }
        public IResult Add(Consulate consulate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Consulate>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Consulate> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Consulate consulate)
        {
            throw new NotImplementedException();
        }
    }
}
