﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntitiyFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(KonsoloslukTakipContext))]
    partial class KonsoloslukTakipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<int>("AppointmentSiteId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("AvailableDate")
                        .HasColumnType("date");

                    b.Property<int>("ConsulateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("VisaCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("VisaTypeId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("AppointmentSiteId");

                    b.HasIndex("ConsulateId");

                    b.HasIndex("VisaCategoryId");

                    b.HasIndex("VisaTypeId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Entities.Concrete.AppointmentSite", b =>
                {
                    b.Property<int>("AppointmentSiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentSiteId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentSiteId");

                    b.HasIndex("CountryId");

                    b.ToTable("AppointmentSites");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Entities.Concrete.Consulate", b =>
                {
                    b.Property<int>("ConsulateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsulateId"));

                    b.Property<string>("ConsulateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryCityId")
                        .HasColumnType("int");

                    b.HasKey("ConsulateId");

                    b.HasIndex("CountryCityId");

                    b.ToTable("Consulates");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Entities.Concrete.CountryCity", b =>
                {
                    b.Property<int>("CountryCityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryCityId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("CountryCityId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("CountryCities");
                });

            modelBuilder.Entity("Entities.Concrete.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NotificationId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Entities.Concrete.PaymentTransaction", b =>
                {
                    b.Property<int>("PaymentTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentTransactionId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateOnly>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<string>("TransacStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentTransactionId");

                    b.HasIndex("SubscriptionId");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentTransactions");
                });

            modelBuilder.Entity("Entities.Concrete.ScrapeLog", b =>
                {
                    b.Property<int>("ScrapeLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScrapeLogId"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<bool>("Result")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ScrapeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ScrapeLogId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("ScrapeLogs");
                });

            modelBuilder.Entity("Entities.Concrete.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionId"));

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("PlanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationPreferences")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Concrete.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Entities.Concrete.UserRoleMapping", b =>
                {
                    b.Property<int>("UserRoleMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleMappingId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleMappingId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("UserRoleMappings");
                });

            modelBuilder.Entity("Entities.Concrete.VisaCategory", b =>
                {
                    b.Property<int>("VisaCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisaCategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisaCategoryId");

                    b.ToTable("VisaCategories");
                });

            modelBuilder.Entity("Entities.Concrete.VisaType", b =>
                {
                    b.Property<int>("VisaTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisaTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisaCategoryId")
                        .HasColumnType("int");

                    b.HasKey("VisaTypeId");

                    b.HasIndex("VisaCategoryId");

                    b.ToTable("VisaTypes");
                });

            modelBuilder.Entity("Entities.Concrete.Appointment", b =>
                {
                    b.HasOne("Entities.Concrete.AppointmentSite", "AppointmentSite")
                        .WithMany("Appointments")
                        .HasForeignKey("AppointmentSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Consulate", "Consulate")
                        .WithMany("Appointments")
                        .HasForeignKey("ConsulateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.VisaCategory", "VisaCategory")
                        .WithMany("Appointments")
                        .HasForeignKey("VisaCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.VisaType", "VisaType")
                        .WithMany("Appointments")
                        .HasForeignKey("VisaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppointmentSite");

                    b.Navigation("Consulate");

                    b.Navigation("VisaCategory");

                    b.Navigation("VisaType");
                });

            modelBuilder.Entity("Entities.Concrete.AppointmentSite", b =>
                {
                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("AppointmentSites")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entities.Concrete.Consulate", b =>
                {
                    b.HasOne("Entities.Concrete.CountryCity", "CountryCity")
                        .WithMany("Consulates")
                        .HasForeignKey("CountryCityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CountryCity");
                });

            modelBuilder.Entity("Entities.Concrete.CountryCity", b =>
                {
                    b.HasOne("Entities.Concrete.City", "City")
                        .WithMany("CountryCities")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("CountryCities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entities.Concrete.Notification", b =>
                {
                    b.HasOne("Entities.Concrete.Appointment", "Appointment")
                        .WithMany("Notifications")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.PaymentTransaction", b =>
                {
                    b.HasOne("Entities.Concrete.Subscription", "Subscription")
                        .WithMany("PaymentTransactions")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("PaymentTransactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.ScrapeLog", b =>
                {
                    b.HasOne("Entities.Concrete.Appointment", "Appointment")
                        .WithMany("ScrapeLogs")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Entities.Concrete.Subscription", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.UserRoleMapping", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("UserRoleMappings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.UserRole", "UserRole")
                        .WithMany("UserRoleMappings")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Entities.Concrete.VisaType", b =>
                {
                    b.HasOne("Entities.Concrete.VisaCategory", "VisaCategory")
                        .WithMany("VisaTypes")
                        .HasForeignKey("VisaCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("VisaCategory");
                });

            modelBuilder.Entity("Entities.Concrete.Appointment", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("ScrapeLogs");
                });

            modelBuilder.Entity("Entities.Concrete.AppointmentSite", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Navigation("CountryCities");
                });

            modelBuilder.Entity("Entities.Concrete.Consulate", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Navigation("AppointmentSites");

                    b.Navigation("CountryCities");
                });

            modelBuilder.Entity("Entities.Concrete.CountryCity", b =>
                {
                    b.Navigation("Consulates");
                });

            modelBuilder.Entity("Entities.Concrete.Subscription", b =>
                {
                    b.Navigation("PaymentTransactions");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("PaymentTransactions");

                    b.Navigation("Subscriptions");

                    b.Navigation("UserRoleMappings");
                });

            modelBuilder.Entity("Entities.Concrete.UserRole", b =>
                {
                    b.Navigation("UserRoleMappings");
                });

            modelBuilder.Entity("Entities.Concrete.VisaCategory", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("VisaTypes");
                });

            modelBuilder.Entity("Entities.Concrete.VisaType", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
