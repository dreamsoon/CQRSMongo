using CQRS.Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Data.Mapping
{
    public class EntryMap : IEntityTypeConfiguration<Entry>
    {
        public void Configure(EntityTypeBuilder<Entry> builder)
        {
            builder.Property(p => p.Description).IsRequired().HasMaxLength(150);
            
        }
    }
}
