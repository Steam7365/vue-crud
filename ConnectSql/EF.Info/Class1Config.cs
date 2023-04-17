using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Info
{
    internal class Class1Config : IEntityTypeConfiguration<Class1>
    {
        public void Configure(EntityTypeBuilder<Class1> builder)
        {
            builder.ToTable("SqlName");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Price).HasColumnType("money");
        }
    }
}
