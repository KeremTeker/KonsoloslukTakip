using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        //burada mesajı alacak ve üst sınıfa bir false ve bir message gönderecek
        public ErrorResult(string message) : base(false, message)
        {
        }

        // message alıp göndermeyecek sadece false gönderecek ana(base) sınıftaki tek olan ctora.
        public ErrorResult() : base(false)
        {
        }
    }
}
