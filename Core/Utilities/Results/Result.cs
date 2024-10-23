using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //bu çalıştığında this(success) dediğimiz için tek parametreli ctorda çalışacak
        //:this(success) bu ifade ctorun aynı class içerisindeki bir başka ctoru çağırmasını sağlıyor
        //yani bu ctor çalışacağı zaman önce diğer ctor sonra bu ctor çalışıyor böylelikle ikisi birden çalışıyor
        //ctorları overload ettiğimiz için zaten parametreleri farklı olmak zorunda. Buyüzden ctorun parametresini verince hangi ctor olduğunu anlıyor.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        //mesaj göstermek istemediğimiz senaryolar için ctoru overload ediyoruz.
        // bu tek çalışacak
        public Result(bool success)
        {
            Success = success;
        }


        // Bunlar readonly olduğu için ekstra fielda gerek yok bunları direk ctor da set edebiliriz
        public bool Success { get; }

        public string Message { get; }
    }
}
