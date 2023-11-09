using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.BLL.Models.ViewModels;
using YemekSiparis.BLL.Services.Basket.Abstract;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.Enums;
using YemekSiparis.Core.IRepositories;
using YemekSiparis.DAL.Repositories;

namespace YemekSiparis.BLL.Services.Basket.Concrete
{
    public class OrderDetailManager : BaseManager<OrderDetail>, IOrderDetailService
    {
        private readonly IBaseRepository<OrderDetail> _baseRepository;

        public OrderDetailManager(IBaseRepository<OrderDetail> baseRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<bool> CreateDetailVM(CreateOrderDetailVM vm)
        {

            //OrderDetail orderDetail = new OrderDetail();
            //orderDetail.FoodID = detailVM.FoodId;
            //orderDetail.OrderBagID = bag.Id;
            //await _orderDetailService.AddAsync(orderDetail);
            throw new NotImplementedException();
        }
    }
}
