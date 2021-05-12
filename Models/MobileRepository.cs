using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCMobileSlut.Models
{
    public class MobileRepository : IMobileRepository
    {
        private readonly AppDbContext _appDbContext;

        public MobileRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Mobile> AllMobiles => _appDbContext.Mobiles.Include(p => p.Category);

        public IEnumerable<Mobile> MobilesOfTheWeek => _appDbContext.Mobiles.Include(p => p.Category).Where(p => p.IsMobileOfTheWeek);

        public Mobile GetMobileByID(int mobileId)
        {
            return _appDbContext.Mobiles.FirstOrDefault(p => p.MobileId == mobileId);
        }
    }
}
