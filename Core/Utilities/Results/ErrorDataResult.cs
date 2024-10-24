using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //success durumu default true

        //ister data ve mesaj ver
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //ister sadece data ver
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //ister sadece mesaj ver
        //default tipin defaultu hiçbir şey döndürmek istemediğimiz zaman kullanırız.
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //istersen hiçbir şey verme
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
