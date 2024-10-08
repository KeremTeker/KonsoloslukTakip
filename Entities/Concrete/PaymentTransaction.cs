﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PaymentTransaction : IEntity
    {
        public int PaymentTransactionId { get; set; }
        public int UserId { get; set; }
        public int SubscriptionId { get; set; }
        public int Amount { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string TransacStatus { get; set; }

        public User User { get; set; }
        public Subscription Subscription { get; set; }
    }
}