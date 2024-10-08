using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Subscription : IEntity
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string PlanType { get; set; }
        public bool Status { get; set; }

        public ICollection<PaymentTransaction> PaymentTransactions { get; set; }

        public User User { get; set; }
    }
}
