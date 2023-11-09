using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.BLL.Models.ViewModels;
using YemekSiparis.Core.Entities;

namespace YemekSiparis.BLL.Services.Basket.Abstract
{
    public interface IOrderDetailService : IBaseService<OrderDetail>
    {

        Task<bool> CreateDetailVM(CreateOrderDetailVM vm);

    }
}
