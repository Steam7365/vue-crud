using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Entityformwork.info.Config
{
    internal class BookTypeConfig : IEntityTypeConfiguration<BookType>
    {
        public void Configure(EntityTypeBuilder<BookType> builder)
        {
            builder.ToTable("BookType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TypeName).HasMaxLength(50);
        }
    }
}
