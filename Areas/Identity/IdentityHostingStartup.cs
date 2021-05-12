using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AspMVCMobileSlut.Models;

//[assembly: HostingStartup(typeof(Vecka01ASPGill01.Areas.Identity.IdentityHostingStartup))]
//namespace AspMVCMobileSlut.Areas.Identity
//{
    //public class IdentityHostingStartup : IHostingStartup
    //{
    //    public void Configure(IWebHostBuilder builder)
    //    {
    //        builder.ConfigureServices((context, services) => {
    //            services.AddDbContext<AppDbContext>(options =>
    //                options.UseSqlServer(
    //                    context.Configuration.GetConnectionString("AppDbContextConnection")));

    //            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    //                .AddEntityFrameworkStores<AppDbContext>();
    //        });
    //    }
    //}
//}