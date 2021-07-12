using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reports.Models
{
    public class Shipping
    {
        public Shipping(string departureCity, string arrivalCity, int plannedShipping,int actualShipping)
        {
            this.DepartureCity = departureCity;
            this.ArrivalCity = arrivalCity;
            this.PlannedShipping = plannedShipping;
            this.CountShippingOnDates = new List<CountShippingOnDate>();
            this.ActualShipping = actualShipping;
        }
        public Shipping() { }
        public int Id { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public int PlannedShipping { get; set; }
        public ICollection<CountShippingOnDate> CountShippingOnDates { get; set; }
        public int ActualShipping { get; set; }
    }
}