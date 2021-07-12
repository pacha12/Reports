using Reports.Models;
using Reports.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Servises.IServises
{
    public interface IShippingServise
    {
        Task<List<DepartureCityViewModel>> GetDepartureCityViewModel();
        Task<IList<Shipping>> GetAll();
    }
}
