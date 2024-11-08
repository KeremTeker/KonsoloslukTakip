using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentTransactionService
    {
        IDataResult<List<PaymentTransaction>> GetAll();
        IResult Add(PaymentTransaction paymentTransaction);
        IDataResult<PaymentTransaction> GetById(int id);
        IResult Update(PaymentTransaction paymentTransaction);
    }
}
