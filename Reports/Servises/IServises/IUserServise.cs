using Reports.Models;
using Reports.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.IServises
{
    public interface IUserServise
    {
        Task<User> GetCurUser(LoginViewModel model);
    }
}
