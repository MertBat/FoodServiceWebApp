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
    public class BeverageManager : BaseManager<Beverage>, IBeverageService
    {
        private readonly IBaseRepository<Beverage> _baseRepository;

        public BeverageManager(IBaseRepository<Beverage> baseRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<decimal> AdditionAsync(List<Beverage> beverages)
        {
            decimal total = 1;

            foreach (Beverage item in beverages)
            {
                total += item.Price;
            }


            return total;

        }
    }
}
