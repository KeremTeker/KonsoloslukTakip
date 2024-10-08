using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "VisaTypes",
                newName: "VisaCategoryId");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "UserRoleMappings",
                newName: "UserRoleId");

            migrationBuilder.RenameColumn(
                name: "SubId",
                table: "PaymentTransactions",
                newName: "SubscriptionId");

            migrationBuilder.RenameColumn(
                name: "SiteId",
                table: "Appointments",
                newName: "VisaCategoryId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Appointments",
                newName: "AppointmentSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_VisaTypes_VisaCategoryId",
                table: "VisaTypes",
                column: "VisaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMappings_UserId",
                table: "UserRoleMappings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMappings_UserRoleId",
                table: "UserRoleMappings",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScrapeLogs_AppointmentId",
                table: "ScrapeLogs",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_SubscriptionId",
                table: "PaymentTransactions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_UserId",
                table: "PaymentTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AppointmentId",
                table: "Notifications",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCities_CityId",
                table: "CountryCities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCities_CountryId",
                table: "CountryCities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulates_CountryCityId",
                table: "Consulates",
                column: "CountryCityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSites_CountryId",
                table: "AppointmentSites",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AppointmentSiteId",
                table: "Appointments",
                column: "AppointmentSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ConsulateId",
                table: "Appointments",
                column: "ConsulateId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VisaCategoryId",
                table: "Appointments",
                column: "VisaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VisaTypeId",
                table: "Appointments",
                column: "VisaTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentSites_AppointmentSiteId",
                table: "Appointments",
                column: "AppointmentSiteId",
                principalTable: "AppointmentSites",
                principalColumn: "AppointmentSiteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Consulates_ConsulateId",
                table: "Appointments",
                column: "ConsulateId",
                principalTable: "Consulates",
                principalColumn: "ConsulateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_VisaCategories_VisaCategoryId",
                table: "Appointments",
                column: "VisaCategoryId",
                principalTable: "VisaCategories",
                principalColumn: "VisaCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_VisaTypes_VisaTypeId",
                table: "Appointments",
                column: "VisaTypeId",
                principalTable: "VisaTypes",
                principalColumn: "VisaTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentSites_Countries_CountryId",
                table: "AppointmentSites",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulates_CountryCities_CountryCityId",
                table: "Consulates",
                column: "CountryCityId",
                principalTable: "CountryCities",
                principalColumn: "CountryCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCities_Cities_CityId",
                table: "CountryCities",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCities_Countries_CountryId",
                table: "CountryCities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Appointments_AppointmentId",
                table: "Notifications",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_Subscriptions_SubscriptionId",
                table: "PaymentTransactions",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "SubscriptionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_Users_UserId",
                table: "PaymentTransactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScrapeLogs_Appointments_AppointmentId",
                table: "ScrapeLogs",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMappings_UserRoles_UserRoleId",
                table: "UserRoleMappings",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "UserRoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMappings_Users_UserId",
                table: "UserRoleMappings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisaTypes_VisaCategories_VisaCategoryId",
                table: "VisaTypes",
                column: "VisaCategoryId",
                principalTable: "VisaCategories",
                principalColumn: "VisaCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentSites_AppointmentSiteId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Consulates_ConsulateId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_VisaCategories_VisaCategoryId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_VisaTypes_VisaTypeId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentSites_Countries_CountryId",
                table: "AppointmentSites");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulates_CountryCities_CountryCityId",
                table: "Consulates");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCities_Cities_CityId",
                table: "CountryCities");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCities_Countries_CountryId",
                table: "CountryCities");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Appointments_AppointmentId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_Subscriptions_SubscriptionId",
                table: "PaymentTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_Users_UserId",
                table: "PaymentTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ScrapeLogs_Appointments_AppointmentId",
                table: "ScrapeLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMappings_UserRoles_UserRoleId",
                table: "UserRoleMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMappings_Users_UserId",
                table: "UserRoleMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_VisaTypes_VisaCategories_VisaCategoryId",
                table: "VisaTypes");

            migrationBuilder.DropIndex(
                name: "IX_VisaTypes_VisaCategoryId",
                table: "VisaTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleMappings_UserId",
                table: "UserRoleMappings");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleMappings_UserRoleId",
                table: "UserRoleMappings");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_ScrapeLogs_AppointmentId",
                table: "ScrapeLogs");

            migrationBuilder.DropIndex(
                name: "IX_PaymentTransactions_SubscriptionId",
                table: "PaymentTransactions");

            migrationBuilder.DropIndex(
                name: "IX_PaymentTransactions_UserId",
                table: "PaymentTransactions");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_AppointmentId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_CountryCities_CityId",
                table: "CountryCities");

            migrationBuilder.DropIndex(
                name: "IX_CountryCities_CountryId",
                table: "CountryCities");

            migrationBuilder.DropIndex(
                name: "IX_Consulates_CountryCityId",
                table: "Consulates");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentSites_CountryId",
                table: "AppointmentSites");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_AppointmentSiteId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ConsulateId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_VisaCategoryId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_VisaTypeId",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "VisaCategoryId",
                table: "VisaTypes",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "UserRoleMappings",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "SubscriptionId",
                table: "PaymentTransactions",
                newName: "SubId");

            migrationBuilder.RenameColumn(
                name: "VisaCategoryId",
                table: "Appointments",
                newName: "SiteId");

            migrationBuilder.RenameColumn(
                name: "AppointmentSiteId",
                table: "Appointments",
                newName: "CategoryId");
        }
    }
}
