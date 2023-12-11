using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Requset.Domain.Core.Requset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requset.Infrastructures.AccessData.RequsetPersonconfig
{
    internal class RequsetPersonConfig : IEntityTypeConfiguration<RequsetPerson>
    {
        public void Configure(EntityTypeBuilder<RequsetPerson> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Family).HasMaxLength(150);
            builder.Property(c => c.Datetime).HasMaxLength(10);
            builder.Property(c => c.City).HasMaxLength(70);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Details).HasMaxLength(500);
            builder.Property(c => c.Phone).HasMaxLength(10);
            builder.Property(c => c.RequsetType).HasMaxLength(50);
            
        }
    }
}
