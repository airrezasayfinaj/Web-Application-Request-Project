using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requset.Infrastructures.AccessData.Common
{
    public class RequsetPersonContextFactory : IDesignTimeDbContextFactory<RequsetContext>
    {
        public RequsetContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RequsetContext>();
            builder.UseSqlServer("Server=.;Database=Request;Integrated Security=True;MultipleActiveResultSets=true");
            return new RequsetContext(builder.Options);
        }
    }
}
