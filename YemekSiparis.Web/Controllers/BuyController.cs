using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using YemekSiparis.BLL.Models.ViewModels;
using YemekSiparis.BLL.Services.Basket.Abstract;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.Enums;

namespace YemekSiparis.Web.Controllers
{
    public class BuyController : Controller
    {
        private readonly IOrderDetailService _orderDetailService;
        private readonly IOrderBagService _orderBagService;

        public BuyController(IOrderDetailService orderDetailService,IOrderBagService orderBagService)
        {
            _orderDetailService = orderDetailService;
            _orderBagService = orderBagService;
        }

        public async Task<IActionResult> Payment( )
        {
            OrderBag orderBag = await _orderBagService.GetByWhereAsync(x=> x.CustomerId == 1 && x.Status == Status.Active);

            OrderDetailVM orderDetailVM = new OrderDetailVM();
            Expression<Func<OrderDetail, object>>[] includes = new Expression<Func<OrderDetail, object>>[]
            {
                //.Include(o => o.OrderDetails)
                //      .ThenInclude(od => od.Beverage)
                //  .FirstOrDefault();
            x =>x.OrderBag,x=>x.Beverages,x=>x.Food,x=>x.Extras
            };
            orderDetailVM.OrderDetails = await _orderDetailService.AllThenInclude(x=>x.OrderBagID == orderBag.Id);

            return View(orderDetailVM);
        }
    }
}
