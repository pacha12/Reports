using Reports.IServises;
using Reports.Models;
using Reports.Models.ViewModels;
using Reports.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Reports.Servises
{
    public class UserServise:IUserServise
    {
        private readonly IUserRepository _userRepository;
        public UserServise(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<User> GetCurUser(LoginViewModel model)
        {
            var user = await _userRepository.GetAll();
            return user.FirstOrDefault(x => x.Login == model.Login && x.Password == model.Password);
        }
    }
}