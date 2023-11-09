using Microsoft.AspNetCore.Mvc;
using YemekSiparis.BLL.Models.DTOs;
using YemekSiparis.BLL.Services.Admin.Bevarage;

namespace YemekSiparis.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BeverageController : Controller
    {
        private readonly IBeverageService beverageService;

        public BeverageController(IBeverageService beverageService)
        {
            this.beverageService = beverageService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await beverageService.GetExtras());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BeverageCreateDTO beverageCreate)
        {
            bool result = await beverageService.AddExtra(beverageCreate);
            if (result == false)
                return View(beverageCreate);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await beverageService.getExtra(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(BeverageUpdateDTO beverageUpdateDTO)
        {
            bool result = await beverageService.UpdateExtra(beverageUpdateDTO);
            if (result == false)
                return View(beverageUpdateDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await beverageService.DeleteExtra(id);
            return RedirectToAction("Index");
        }
    }
}
