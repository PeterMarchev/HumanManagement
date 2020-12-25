//using System;
//using HumanManagement.Data;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//[assembly: HostingStartup(typeof(HumanManagement.Areas.Identity.IdentityHostingStartup))]
//namespace HumanManagement.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<HumanManagementContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("HumanManagementContextConnection")));

//                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                    .AddEntityFrameworkStores<HumanManagementContext>();
//            });
//        }
//    }
//}