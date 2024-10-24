using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //success durumu default true

        //ister data ve mesaj ver
        public SuccessDataResult(   T data, string message):base(data,true,message)
        {
            
        }
        //ister sadece data ver
        public SuccessDataResult(T data):base(data,true)
        {
            
        }
        //ister sadece mesaj ver
        //default tipin defaultu hiçbir şey döndürmek istemediğimiz zaman kullanırız.
        public SuccessDataResult(string message):base(default,true,message)
        {
            
        }
        //istersen hiçbir şey verme
        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
