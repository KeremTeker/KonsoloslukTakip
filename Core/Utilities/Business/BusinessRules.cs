using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //params yazdığımız zaman Run içerisine istediğimiz kadar IResult verebiliriz.
        //logicsden kastımız yazdığımız iş kuralı methodları dizisi.
        //IResult tipindeki logics ismindeki array içerisine istediğimiz kadar IResult tipinde eleman geçebiliriz params sayesinde.
        //Burada hatalı logicleri businessa bildirmiş oluyoruz.
        public static IResult Run(params IResult[] logics )
        {
            foreach (var logic in logics)
            {
                //logic başarısız ise
                if (!logic.Success)
                {
                    //errorResult döndürecek.
                    return logic;
                }
            }
            return null;
        }
    }
}
