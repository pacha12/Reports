using Reports.Models;
using Reports.Models.ViewModels;
using Reports.Repositories.IRepositories;
using Reports.Servises.IServises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Reports.Controllers
{
    public class ShippingController : Controller
    {
        private readonly IShippingServise _shippingServise;
        public ShippingController(IShippingServise _shippingServise)
        {
            this._shippingServise = _shippingServise;
        }
        public async Task<ActionResult> ShowReportPlanFact()
        {
            if (CurrentUser.User != null)
            {
                return View(await _shippingServise.GetAll());
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        public async Task<ActionResult> ShowReportFactGrouping()
        {
            if (CurrentUser.User != null)
            {
                return View(await _shippingServise.GetDepartureCityViewModel());
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        [HttpPost]
        public async Task<ActionResult> FilterReportPlanFact(FilterReportPlanFactViewModel filterReportPlanFactViewModel)
        {
            switch (filterReportPlanFactViewModel.TypeCity)
            {
                case "departureCity":
                    var departureCityData = await _shippingServise.GetAll();
                    return View("ShowReportPlanFact", departureCityData.Where(x => x.DepartureCity == filterReportPlanFactViewModel.City).ToList());

                case "arrivalCity":
                    var arrivalCityData = await _shippingServise.GetAll();
                    return View("ShowReportPlanFact", arrivalCityData.Where(x => x.ArrivalCity == filterReportPlanFactViewModel.City).ToList());

                default: return View("ShowReportPlanFact", await _shippingServise.GetAll());
            }
        }

        public ActionResult Choice()
        {
            if (CurrentUser.User != null&& CurrentUser.User.AccessReport1 && CurrentUser.User.AccessReport2)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
    }
}