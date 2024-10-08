using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    //Db deki gerçek tablolar ile entity classlarını burada bağlıyoruz
    public class KonsoloslukTakipContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //proje hangi veri tabanıyla ilişkili
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=KonsoloslukTakipDb;User Id=sa;Password=147852369;TrustServerCertificate=True;");


        }

        // OnModelCreating metodunu ekliyoruz
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CountryCity ile Country arasındaki ilişkiyi tanımlıyoruz ve NoAction olarak işaretliyoruz
            modelBuilder.Entity<CountryCity>()
                .HasOne(cc => cc.Country)
                .WithMany(c => c.CountryCities)
                .HasForeignKey(cc => cc.CountryId)
                .OnDelete(DeleteBehavior.NoAction); // Cascade delete yerine NoAction

            // CountryCity ile City arasındaki ilişkiyi tanımlıyoruz ve NoAction olarak işaretliyoruz
            modelBuilder.Entity<CountryCity>()
                .HasOne(cc => cc.City)
                .WithMany(c => c.CountryCities)
                .HasForeignKey(cc => cc.CityId)
                .OnDelete(DeleteBehavior.NoAction); // Cascade delete yerine NoAction

            // Diğer foreign key ilişkileri için de DeleteBehavior.NoAction kullanarak tanımlama yapmalıyız
            // Örneğin Consulate ve CountryCity arasında:
            modelBuilder.Entity<Consulate>()
                .HasOne(c => c.CountryCity)
                .WithMany(cc => cc.Consulates)
                .HasForeignKey(c => c.CountryCityId)
                .OnDelete(DeleteBehavior.NoAction);

            // Subscriptions ve Users arasındaki ilişkiyi NoAction olarak ayarla
            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.User)
                .WithMany(u => u.Subscriptions)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            //VisaType ve VisaCategory
            modelBuilder.Entity<VisaType>()
                .HasOne(vt => vt.VisaCategory)
                .WithMany(vc => vc.VisaTypes)
                .HasForeignKey(vt => vt.VisaCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }




        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentSite> AppointmentSites { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Consulate> Consulates { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryCity> CountryCities { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<ScrapeLog> ScrapeLogs { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserRoleMapping> UserRoleMappings { get; set; }
        public DbSet<VisaCategory> VisaCategories { get; set; }
        public DbSet<VisaType> VisaTypes { get; set; }

    }
}
