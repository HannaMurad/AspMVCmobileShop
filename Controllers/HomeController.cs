using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCMobileSlut.Models;
using AspMVCMobileSlut.ViewModels;

namespace AspMVCMobileSlut.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMobileRepository _mobileRepository;

        public HomeController(IMobileRepository mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                MobilesOfTheWeek = _mobileRepository.MobilesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
