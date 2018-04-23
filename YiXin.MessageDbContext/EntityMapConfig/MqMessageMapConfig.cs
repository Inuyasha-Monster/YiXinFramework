using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YiXin.MessageDbContext.EntityMapConfig
{
    public class MqMessageMapConfig : IEntityTypeConfiguration<MqMessage>
    {
        public void Configure(EntityTypeBuilder<MqMessage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("char(36)").HasDefaultValueSql<Guid>("UUID()");
            builder.Property(x => x.IsPublished).HasDefaultValue(false);
            builder.Property(x => x.MessageAssemblyName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MessageClassFullName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Body).IsRequired().HasMaxLength(4000);
            builder.Property(x => x.PublishedErrorMsg).HasMaxLength(500);
            builder.Property(x => x.CreationDateTime).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
