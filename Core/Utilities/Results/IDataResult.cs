using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Mesajla success durumu IResult ta var zaten
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
