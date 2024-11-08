using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IScrapeLogService
    {
        IDataResult<List<ScrapeLog>> GetAll();
        IResult Add(ScrapeLog scrapeLog);
        IDataResult<ScrapeLog> GetById(int id);
        IResult Update(ScrapeLog scrapeLog);
    }
}
