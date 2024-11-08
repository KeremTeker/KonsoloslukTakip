using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentTransactionManager : IPaymentTransactionService
    {
        IPaymentTransactionDal _paymentTransactionDal;
        public PaymentTransactionManager(IPaymentTransactionDal paymentTransactionDal)
        {
            _paymentTransactionDal = paymentTransactionDal;
        }
        public IResult Add(PaymentTransaction paymentTransaction)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PaymentTransaction>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<PaymentTransaction> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PaymentTransaction paymentTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
