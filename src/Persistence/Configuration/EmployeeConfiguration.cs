﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(f => f.CreatedByUserId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32)
                .IsUnicode(false);

            builder.Property(f => f.MiddleName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(f => f.UserId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32)
                .IsUnicode(false);

            builder.Property(f => f.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32)
                .IsUnicode(false);

            builder.HasOne(f => f.User)
                .WithOne(f => f.Employee)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(f => f.CreatedByUser)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
