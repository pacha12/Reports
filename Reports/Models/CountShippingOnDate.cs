using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reports.Models
{
    public class CountShippingOnDate
    {
        public CountShippingOnDate(int count, int dayOfMonth)
        {
            this.Count = count;
            this.DayOfMonth = dayOfMonth;
        }
        public CountShippingOnDate() { }
        public int Id { get; set; }
        public int Count { get; set; }
        public int DayOfMonth { get; set; }
        public int IdShipping { get; set; }
    }
}