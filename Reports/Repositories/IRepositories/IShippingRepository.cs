﻿using Reports.Models;
using Reports.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Repositories.IRepositories
{
    public interface IShippingRepository
    {
        Task<IList<Shipping>> GetAll();
    }
}
