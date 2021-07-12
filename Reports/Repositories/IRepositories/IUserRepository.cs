using Reports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Repositories.IRepositories
{
    public interface IUserRepository
    {
        Task<IList<User>> GetAll();
    }
}
