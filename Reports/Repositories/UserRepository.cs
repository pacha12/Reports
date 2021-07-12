using Reports.Context;
using Reports.Models;
using Reports.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Reports.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly DbReports _dbReports;
        public UserRepository(DbReports _dbReports)
        {
            this._dbReports = _dbReports;
        }
        async public Task<IList<User>> GetAll()
        {
            return _dbReports.Users.ToList();
        }
    }
}