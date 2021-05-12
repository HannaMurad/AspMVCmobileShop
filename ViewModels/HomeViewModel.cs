using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCMobileSlut.Models;

namespace AspMVCMobileSlut.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Mobile> MobilesOfTheWeek { get; set; }
    }
}
