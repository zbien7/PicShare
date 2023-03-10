using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PicShare.Areas.Identity.Data;
using PicShare.Data;

[assembly: HostingStartup(typeof(PicShare.Areas.Identity.IdentityHostingStartup))]
namespace PicShare.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PicShareDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PicShareDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<PicShareDbContext>();
            });
        }
    }
}