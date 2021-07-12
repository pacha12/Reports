using Reports.Context;
using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reports.Initializer
{
    public class MyContextInitializer : CreateDatabaseIfNotExists<DbReports>
    {
        protected override void Seed(DbReports db)
        {
            User user = new User("Admin", "Admin", true, true);
            User user2 = new User("Admin1", "Admin1", true, false);
            User user3 = new User("Admin2", "Admin2", false, true);
            db.Users.Add(user);
            db.Users.Add(user2);
            db.Users.Add(user3);

            ////////////////////TEST/////////////////////////
            Shipping shipping = new Shipping("Днепр", "Харьков", 15, 5);
            shipping.CountShippingOnDates.Add(new CountShippingOnDate(2, 4));
            shipping.CountShippingOnDates.Add(new CountShippingOnDate(1, 20));
            shipping.CountShippingOnDates.Add(new CountShippingOnDate(1, 15));
            shipping.CountShippingOnDates.Add(new CountShippingOnDate(1, 5));

            Shipping shipping2 = new Shipping("Днепр", "Запорожье", 7, 7);
            shipping2.CountShippingOnDates.Add(new CountShippingOnDate(2, 30));
            shipping2.CountShippingOnDates.Add(new CountShippingOnDate(1, 25));
            shipping2.CountShippingOnDates.Add(new CountShippingOnDate(2, 12));
            shipping2.CountShippingOnDates.Add(new CountShippingOnDate(1, 4));
            shipping2.CountShippingOnDates.Add(new CountShippingOnDate(1, 1));

            Shipping shipping3 = new Shipping("Харьков", "Одесса", 15, 5);
            shipping3.CountShippingOnDates.Add(new CountShippingOnDate(2, 4));
            shipping3.CountShippingOnDates.Add(new CountShippingOnDate(1, 20));
            shipping3.CountShippingOnDates.Add(new CountShippingOnDate(1, 15));
            shipping3.CountShippingOnDates.Add(new CountShippingOnDate(1, 5));
            Shipping shipping4 = new Shipping("Харьков", "Днепр", 20, 10);
            shipping4.CountShippingOnDates.Add(new CountShippingOnDate(2, 4));
            shipping4.CountShippingOnDates.Add(new CountShippingOnDate(1, 20));
            shipping4.CountShippingOnDates.Add(new CountShippingOnDate(1, 15));
            shipping4.CountShippingOnDates.Add(new CountShippingOnDate(1, 5));
            shipping4.CountShippingOnDates.Add(new CountShippingOnDate(3, 22));
            shipping4.CountShippingOnDates.Add(new CountShippingOnDate(2, 1));

            db.Shippings.Add(shipping);
            db.Shippings.Add(shipping2);
            db.Shippings.Add(shipping3);
            db.Shippings.Add(shipping4);



            db.SaveChanges();
        }
    }
}