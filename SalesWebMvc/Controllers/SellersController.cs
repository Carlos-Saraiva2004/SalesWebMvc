using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModel;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;
        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            List<Seller> sellers = _sellerService.FindAll();
            SellerFormViewModel ViewModel = new SellerFormViewModel { Sellers = sellers };
            return View(ViewModel);
        }

        public IActionResult Create()
        {
            List<Department> list = _departmentService.FindAll();
            SellerFormViewModel ViewModel = new SellerFormViewModel { Departments = list };
            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Seller seller = _sellerService.FindById(id.Value);
            if(seller == null)
            {
                return NotFound();
            }
            SellerFormViewModel ViewModel = new SellerFormViewModel { Seller = seller };
            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Seller seller = _sellerService.FindById(id.Value);
            if (seller == null)
            {
                return NotFound();
            }
            SellerFormViewModel ViewModel = new SellerFormViewModel { Seller = seller };
            return View(ViewModel);
        }
    }
}
