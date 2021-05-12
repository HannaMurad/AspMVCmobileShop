using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCMobileSlut.Models;
using AspMVCMobileSlut.ViewModels;

namespace AspMVCMobileSlut.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMobileRepository _mobileRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMobileRepository mobileRepository, ShoppingCart shoppingCart)
        {
            _mobileRepository = mobileRepository;
            _shoppingCart = shoppingCart;
        }
        
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int mobileId)
        {
            var selectedMobile = _mobileRepository.AllMobiles.FirstOrDefault(p => p.MobileId == mobileId);

            if (selectedMobile != null)
            {
                _shoppingCart.AddToCart(selectedMobile, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveToShoppingCart(int mobileId)
        {
            var selectedMobile = _mobileRepository.AllMobiles.FirstOrDefault(p => p.MobileId == mobileId);

            if (selectedMobile != null)
            {
                _shoppingCart.RemoveFromCart(selectedMobile);
            }
            return RedirectToAction("Index");
        }

    }
}
