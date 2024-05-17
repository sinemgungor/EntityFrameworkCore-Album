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
    public class Album_CFG : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            builder.Property(x => x.ReleaseDate).HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal").HasPrecision(10,2).IsRequired();
            builder.Property(x => x.Discount).HasColumnType("decimal").HasPrecision(5,2).IsRequired();
        }
    }
}
