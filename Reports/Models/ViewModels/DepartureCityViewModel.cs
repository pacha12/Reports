using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reports.Models.ViewModels
{
    public class DepartureCityViewModel
    {
        public DepartureCityViewModel()
        {
            ArrivalCityDataViewVodels = new List<ArrivalCityDataViewVodel>();
            TotalPlannedShipping = 0;
            TotalActualShipping = 0;
        }
        public string DepartureCity { get; set; }
        public List<ArrivalCityDataViewVodel> ArrivalCityDataViewVodels { get; set; }
        public int TotalPlannedShipping { get; set; }
        public int TotalActualShipping { get; set; }
    }
}