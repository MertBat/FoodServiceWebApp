﻿using Microsoft.AspNetCore.Mvc;
using YemekSiparis.BLL.Models.DTOs;
using YemekSiparis.BLL.Services.Admin.Extra;
using YemekSiparis.Core.Entities;

namespace YemekSiparis.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExtraController : Controller
    {
        private readonly IExtraService extraService;

        public ExtraController(IExtraService extraService)
        {
            this.extraService = extraService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await extraService.GetExtras());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExtraCreateDTO extraCreateDTO)
        {
            bool result = await extraService.AddExtra(extraCreateDTO);
            if(result == false)
                return View(extraCreateDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await extraService.getExtra(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ExtraUpdateDTO extraUpdateDTO)
        {
            bool result = await extraService.UpdateExtra(extraUpdateDTO);
            if (result == false)
                return View(extraUpdateDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            bool result = await extraService.DeleteExtra(id);
            return RedirectToAction("Index");
        }
    }
}