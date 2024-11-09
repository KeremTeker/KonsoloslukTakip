using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string NotificationPreferences { get; set; }
        

        public ICollection<Notification> Notifications { get; set; }
        public ICollection<PaymentTransaction> PaymentTransactions { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<UserRoleMapping> UserRoleMappings { get; set; }
    }
}
