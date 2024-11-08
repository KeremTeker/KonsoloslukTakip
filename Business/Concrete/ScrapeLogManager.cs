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
    public class ScrapeLogManager : IScrapeLogService
    {
        IScrapeLogDal _scrapeLogDal;
        public ScrapeLogManager(IScrapeLogDal scrapeLogDal)
        {
            _scrapeLogDal = scrapeLogDal;
        }
        public IResult Add(ScrapeLog scrapeLog)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ScrapeLog>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ScrapeLog> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ScrapeLog scrapeLog)
        {
            throw new NotImplementedException();
        }
    }
}
