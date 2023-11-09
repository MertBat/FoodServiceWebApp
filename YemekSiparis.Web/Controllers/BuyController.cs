using Microsoft.AspNetCore.Mvc;
using YemekSiparis.BLL.Models.ViewModels;

namespace YemekSiparis.Web.Controllers
{
    public class BuyController : Controller
    {
        public IActionResult Payment(CreateOrderDetailVM detailVM)
        {

            return View(detailVM);
        }
    }
}
