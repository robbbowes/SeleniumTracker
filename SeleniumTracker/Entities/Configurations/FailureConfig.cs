using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeleniumTracker.Models;

namespace SeleniumTracker.Entities.Configurations
{
    public class FailureConfig : IEntityTypeConfiguration<Failure>
    {
        public void Configure(EntityTypeBuilder<Failure> builder)
        {
            builder.Property(p => p.Date).HasColumnType("date").HasDefaultValue(DateTime.Now);
        }
    }
}
