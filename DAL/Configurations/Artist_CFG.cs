using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class Artist_CFG : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            builder.Property(x => x.Surname).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        }
    }
}
