using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {

        //burada mesajı alacak ve üst sınıfa bir true ve bir message gönderecek
        public SuccessResult(string message) : base(true,message)
        {
        }

        // message alıp göndermeyecek sadece true gönderecek ana(base) sınıftaki tek olan ctora.
        public SuccessResult() : base(true)
        {
        }
    }
}
