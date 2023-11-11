using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.BLL.Services.Basket.Abstract;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.IRepositories;

namespace YemekSiparis.BLL.Services.Basket.Concrete
{
    public class CustomerManager : BaseManager<Customer>, ICustomerService
    {
        private readonly IBaseRepository<Customer> _baseRepository;

        public CustomerManager(IBaseRepository<Customer> baseRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
        }




    }
}
