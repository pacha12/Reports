using Reports.Models;
using Reports.Models.ViewModels;
using Reports.Repositories.IRepositories;
using Reports.Servises.IServises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Reports.Servises
{
    public class ShippingServise:IShippingServise
    {
        private readonly IShippingRepository _shippingRepository;
        public ShippingServise(IShippingRepository shippingRepository)
        {
            this._shippingRepository = shippingRepository;
        }

        public async Task<IList<Shipping>> GetAll()
        {
            return await _shippingRepository.GetAll();
        }

        public async Task<List<DepartureCityViewModel>> GetDepartureCityViewModel()
        {
            List<DepartureCityViewModel> departureCityViewModel = new List<DepartureCityViewModel>();
            var tmplistShipping = await _shippingRepository.GetAll();
            var tmpListDepartureCity = new List<string>();
            foreach (var shipping in tmplistShipping)
            {
                if (departureCityViewModel.FirstOrDefault(x => x.DepartureCity == shipping.DepartureCity) == null)
                {
                    var totalPlannedShipping = 0;
                    var totalActualShipping = 0;
                    var arrivalCityes = tmplistShipping.Where(x => x.DepartureCity == shipping.DepartureCity);
                    List<ArrivalCityDataViewVodel> arrivalCityDataViewVodel = new List<ArrivalCityDataViewVodel>();
                    foreach (var item in arrivalCityes)
                    {
                        totalPlannedShipping += item.PlannedShipping;
                        totalActualShipping += item.ActualShipping;
                        arrivalCityDataViewVodel.Add(new ArrivalCityDataViewVodel() { ActualShipping = item.ActualShipping, ArrivalCity = item.ArrivalCity, PlannedShipping = item.PlannedShipping });
                    }
                    departureCityViewModel.Add(new DepartureCityViewModel() { DepartureCity = shipping.DepartureCity, ArrivalCityDataViewVodels = arrivalCityDataViewVodel, TotalActualShipping= totalActualShipping, TotalPlannedShipping= totalPlannedShipping });
                }
            }
            return departureCityViewModel;
        }

    }
}