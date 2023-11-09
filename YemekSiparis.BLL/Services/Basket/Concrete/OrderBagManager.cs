using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.BLL.Services.Basket.Abstract;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.Enums;
using YemekSiparis.Core.IRepositories;
using YemekSiparis.DAL.Repositories;

namespace YemekSiparis.BLL.Services.Basket.Concrete
{
    public class OrderBagManager : BaseManager<OrderBag>, IOrderBagService
    {
        private readonly IBaseRepository<OrderBag> _baseRepository;

        public OrderBagManager(IBaseRepository<OrderBag> baseRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<int> GetOrderBagID(OrderBag orderBag)
        {
            if(orderBag == null) 
                return 0;
            else
            {
                orderBag.CustomerId = 1;
                orderBag.OrderStatus = OrderStatus.InProgress;
                await _baseRepository.AddAsync(orderBag);
                return orderBag.Id;
            }
         
        }
    }
}
