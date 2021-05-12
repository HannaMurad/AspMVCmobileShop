using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCMobileSlut.Models;
using AspMVCMobileSlut.ViewModels;

namespace AspMVCMobileSlut.Controllers
{
    public class MobileController : Controller
    {
        private readonly IMobileRepository _mobileRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MobileController(IMobileRepository mobileRepository, ICategoryRepository categoryRepository)
        {
            _mobileRepository = mobileRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    PiesListViewModel piesListViewModel = new PiesListViewModel();
        //    piesListViewModel.Pies = _pieRepository.AllPies;
        //    piesListViewModel.CurrentCategory = "Cheese Cakes";

        //    return View(piesListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Mobile> mobiles;
            string currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                mobiles = _mobileRepository.AllMobiles.OrderBy(p => p.MobileId);
                currentCategory = "All mobiles";
            }
            else
            {
                mobiles = _mobileRepository.AllMobiles.Where(p => p.Category.CategoryName == category).OrderBy(p => p.MobileId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new MobilesListViewModel
            {
                Mobiles = mobiles,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var mobile = _mobileRepository.GetMobileByID(id);
            if (mobile == null) return NotFound();
            return View(mobile);
        }
    }
}
