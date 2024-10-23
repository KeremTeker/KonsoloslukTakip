using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için
    //methodlarda tek bir şey döndürebiliyoruz ama biz birden fazla şey döndürmek istiyoruz, oyüzden bu yaoıyı kuruyoruz.
    public interface IResult
    {
        //sadece okuyacaz
        bool Success { get; }
        string Message { get; }
    }
}
