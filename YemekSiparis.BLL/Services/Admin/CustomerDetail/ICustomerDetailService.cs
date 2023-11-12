﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.Core.Entities;

namespace YemekSiparis.BLL.Services.Admin.CustomerDetail
{
    public interface ICustomerDetailService
    {
        Task<List<Customer>> GetAll();
    }
}
