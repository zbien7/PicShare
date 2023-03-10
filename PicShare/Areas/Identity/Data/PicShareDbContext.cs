using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PicShare.Areas.Identity.Data;

namespace PicShare.Data
{
    public class PicShareDbContext : IdentityDbContext<ApplicationUser>
    {
        public PicShareDbContext(DbContextOptions<PicShareDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PhotoGraphy> PhotoGraphy { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
