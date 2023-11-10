using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using YemekSiparis.BLL.Helper;
using YemekSiparis.BLL.Models.ViewModels;
using YemekSiparis.BLL.Services.Basket.Abstract;
using YemekSiparis.BLL.Validations;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.Enums;
using YemekSiparis.Core.IRepositories;
using YemekSiparis.DAL.Repositories;

namespace YemekSiparis.Web.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBaseRepository<OrderDetail> _baseRepository;
        private readonly IExtraRepository _extraRepository;
        private readonly IBeverageRepository _beverageRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IOrderBagRepository _orderBagRepository;
        private readonly ICreateOrderService _createOrderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IExtraService _extraService;
        private readonly IBeverageService _beverageService;
        private readonly IOrderDetailBeverageService _orderBeverageService;
        private readonly IOrderDetailExtraService _orderExtraService;
        private readonly IOrderBagService _orderBagService;
        private readonly IMapper _mapper;

        public BasketController(IBaseRepository<OrderDetail> baseRepository, IExtraRepository extraRepository, IBeverageRepository beverageRepository, IFoodRepository foodRepository, IOrderDetailRepository orderDetailRepository, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IOrderBagRepository orderBagRepository, ICreateOrderService createOrderService, IOrderDetailService orderDetailService, IExtraService extraService, IBeverageService beverageService, IOrderDetailBeverageService orderBeverageService, IOrderDetailExtraService orderExtraService, IOrderBagService orderBagService,IMapper mapper)
        {
            _baseRepository = baseRepository;
            _extraRepository = extraRepository;
            _beverageRepository = beverageRepository;
            _foodRepository = foodRepository;
            _orderDetailRepository = orderDetailRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _orderBagRepository = orderBagRepository;
            _createOrderService = createOrderService;
            _orderDetailService = orderDetailService;
            _extraService = extraService;
            _beverageService = beverageService;
            _orderBeverageService = orderBeverageService;
            _orderExtraService = orderExtraService;
            _orderBagService = orderBagService;
            _mapper = mapper;
        }

        public IActionResult Menu()
        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllMenu()
        {
            Expression<Func<Food, object>>[] includes = new Expression<Func<Food, object>>[]
           {
              x=> x.Category, x=> x.Diets
           };
            ListFoodVM listFoodVM = new ListFoodVM();
            listFoodVM.Foods = await _foodRepository.AllIncludeFood(x => x.Status == Status.Active, includes);
            return PartialView("_MenuPartialView", listFoodVM);
        }

        public async Task<IActionResult> HamburgerMenu()
        {
            Expression<Func<Food, object>>[] includes = new Expression<Func<Food, object>>[]
           {
                 x=> x.Category, x=> x.Diets
           };
            ListFoodVM listFoodVM = new ListFoodVM();
            listFoodVM.Foods = await _foodRepository.AllIncludeFood(x => x.CategoryID == 1 && x.Status == Status.Active, includes);
            return PartialView("_MenuPartialView", listFoodVM);
        }


        public async Task<IActionResult> PizzaMenu()
        {
            Expression<Func<Food, object>>[] includes = new Expression<Func<Food, object>>[]
            {
                x=> x.Category, x=> x.Diets
            };
            ListFoodVM listFoodVM = new ListFoodVM();
            listFoodVM.Foods = await _foodRepository.AllIncludeFood(x => x.CategoryID == 2 && x.Status == Status.Active, includes);
            return PartialView("_MenuPartialView", listFoodVM);
        }

        public async Task<IActionResult> PastaMenu()
        {
            Expression<Func<Food, object>>[] includes = new Expression<Func<Food, object>>[]
            {
                x=>x.Category, x=> x.Diets
            };

            ListFoodVM listFoodVM = new ListFoodVM();
            listFoodVM.Foods = await _foodRepository.AllIncludeFood(x => x.CategoryID == 3 && x.Status == Status.Active, includes);

            return PartialView("_MenuPartialView", listFoodVM);
        }

        public async Task<IActionResult> CreateOrder(int id)
        {
            CreateOrderDetailVM vm = await _createOrderService.CreateAsync(id);
            if (vm == null)
                return RedirectToAction("Menu");
            else
                return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderDetailVM detailVM)
        {
            CreateOrderDetailVMValidator validator = new CreateOrderDetailVMValidator();
            var result = validator.Validate(detailVM);

            OrderBag orderBag = await _orderBagRepository.GetByWhereAsync(x => x.CustomerId == 1 && x.Status == Status.Active);
            OrderBag bag = new OrderBag();

            OrderDetail orderDetail = new OrderDetail();
            if (orderBag == null)
            {
                orderDetail.OrderBagID = await _orderBagService.GetOrderBagID(bag);
            }
            else
                orderDetail.OrderBagID = orderBag.Id;

            orderDetail.Quantity = detailVM.Quantity;
            orderDetail.FoodID = detailVM.FoodId;
            orderDetail.FoodSize = detailVM.FoodSize;
            await _orderDetailService.AddAsync(orderDetail);


            OrderDetailExtra extra = new OrderDetailExtra();
            await _orderExtraService.AddExtraToOrder(extra, orderDetail.Id);

            OrderDetailBeverage beverage = new OrderDetailBeverage();
            await _orderBeverageService.AddBeverageToOrder(beverage, orderDetail.Id);
        
            Expression<Func<OrderDetail, object>>[] includes = new Expression<Func<OrderDetail, object>>[]
            {
                x=>x.Beverages, x=>x.Extras,x=>x.Food
            };
            if (orderBag != null)
            {
                orderBag.TotalPrice = await _orderBagService.TotalPayment(await _orderDetailRepository.AllIncludeOrderDetail(x => x.Status == Status.Active && x.OrderBagID == bag.Id, includes));
                await _orderBagService.DefaultUpdate(orderBag);
            }
            else
            {
                bag.TotalPrice = await _orderBagService.TotalPayment(await _orderDetailRepository.AllIncludeOrderDetail(x => x.Status == Status.Active && x.OrderBagID == bag.Id, includes));
                await _orderBagService.DefaultUpdate(bag);
            }
            orderDetail.UnitPrice = await _orderBagService.TotalPayment(await _orderDetailRepository.AllIncludeOrderDetail(x => x.Id == orderDetail.Id && x.Status == Status.Active, includes));
            await _orderDetailService.DefaultUpdateAsync(orderDetail);

            DataClear.Clear();
            return RedirectToAction("Menu");
        }



        [HttpPost]
        public async Task<IActionResult> TotalPrice(CreateOrderDetailVM detailVM)
        {

            Food food = await _foodRepository.GetByAllInclude(x => x.Id == detailVM.FoodId);
            if ((detailVM.ExtraId != 0) && detailVM.IsSelected == true)
                ExtraData.Extras.Add(await _extraRepository.GetByIdAsync(detailVM.ExtraId));
            else if ((detailVM.ExtraId != 0) && detailVM.IsSelected == false)
            {
                Extra extra = null;

                foreach (var element in ExtraData.Extras)
                {
                    if (element.Id == detailVM.ExtraId)
                    {
                        extra = element;
                        break;
                    }
                }
                ExtraData.Extras.Remove(extra);
            }

            if (detailVM.BeverageId != 0 && detailVM.IsSelected == true)
                BeverageData.Beverages.Add(await _beverageRepository.GetByIdAsync(detailVM.BeverageId));
            else if (detailVM.BeverageId != 0 && detailVM.IsSelected == false)
                BeverageData.Beverages.Remove(await _beverageRepository.GetByIdAsync(detailVM.BeverageId));


            decimal size = FoodSizeResult.SizePrice(detailVM.FoodSize);

            if (ExtraData.Extras.Count <= 0 && BeverageData.Beverages.Count <= 0)
                detailVM.TotalPrice = Math.Round((food.Price * (1 - food.Discount)) * detailVM.Quantity, 2) * size;
            else if (ExtraData.Extras.Count > 0 && BeverageData.Beverages.Count <= 0)
                detailVM.TotalPrice = Math.Round((food.Price * (1 - food.Discount)) * detailVM.Quantity * size + await _extraService.AdditionAsync(ExtraData.Extras), 2);
            else if (BeverageData.Beverages.Count > 0 && ExtraData.Extras.Count <= 0)
                detailVM.TotalPrice = Math.Round((food.Price * (1 - food.Discount)) * detailVM.Quantity * size + await _beverageService.AdditionAsync(BeverageData.Beverages), 2);
            else
                detailVM.TotalPrice = Math.Round((food.Price * (1 - food.Discount)) * detailVM.Quantity * size + await _extraService.AdditionAsync(ExtraData.Extras) + await _beverageService.AdditionAsync(BeverageData.Beverages), 2);

            return PartialView("_TotalPricePartial", detailVM);


        }


    }
}



//foreach (Beverage item in BeverageData.Beverages)
//{
//    beverage.OrderDetailID = orderDetail.Id;
//    beverage.BeverageID = item.Id;
//    await _orderBeverageService.AddAsync(beverage);
//}


//beverage.Beverage = await _beverageRepository.GetByIdAsync(detailVM.BeverageId);
//beverage.OrderDetail = orderDetail;
//orderDetail.Beverages.Add(beverage);


//extra.Extra = await _extraRepository.GetByIdAsync(detailVM.ExtraId);
//extra.OrderDetail = orderDetail;
//orderDetail.Extras.Add(extra);


//foreach (Extra item in ExtraData.Extras)
//{
//    extra.OrderDetailID = orderDetail.Id;
//    extra.ExtraID = item.Id;
//    await _orderExtraService.AddAsync(extra);
//}


//bag.CustomerId = 1;
//bag.OrderStatus = detailVM.OrderStatus;
//await _orderBagRepository.AddAsync(bag);


//Expression<Func<OrderDetail, object>>[] deneme = new Expression<Func<OrderDetail, object>>[]
//{
//    x=> x.Beverages,x=> x.Extras
//};

//List<OrderDetail> order = await _orderDetailRepository.AllIncludeOrderDetail(deneme);
