using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCMobileSlut.Models
{
    public interface IMobileRepository
    {
        IEnumerable<Mobile> AllMobiles { get; }
        IEnumerable<Mobile> MobilesOfTheWeek { get; }
        Mobile GetMobileByID(int mobileId);
    }
}
