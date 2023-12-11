using Microsoft.EntityFrameworkCore;
using Requset.Domain.Core.Requset;
using Requset.Infrastructures.AccessData.RequsetPersonconfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requset.Infrastructures.AccessData.Common
{
    public class RequsetContext : DbContext
    {
        public DbSet<RequsetPerson> requsetPeople { get; set; }
        public RequsetContext(DbContextOptions<RequsetContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequsetPersonConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
