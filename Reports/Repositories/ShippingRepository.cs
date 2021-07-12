using Reports.Context;
using Reports.Models;
using Reports.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Reports.Repositories
{
    public class ShippingRepository : IShippingRepository
    {
        private readonly DbReports _dbReports;
        public ShippingRepository(DbReports _dbReports)
        {
            this._dbReports = _dbReports;
        }
        async public Task<IList<Shipping>> GetAll()
        {
            return _dbReports.Shippings.Include(x => x.CountShippingOnDates).ToList();
        }
    }
}