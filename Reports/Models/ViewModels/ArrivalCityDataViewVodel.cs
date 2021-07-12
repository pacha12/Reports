using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reports.Models.ViewModels
{
    public class ArrivalCityDataViewVodel
    {
        public string ArrivalCity { get; set; }
        public int PlannedShipping { get; set; }
        public int ActualShipping { get; set; }
    }
}