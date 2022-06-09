using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeleniumTracker.Models;

namespace SeleniumTracker.Entities.Configurations
{
    public class ResolutionConfig : IEntityTypeConfiguration<Resolution>
    {
        public void Configure(EntityTypeBuilder<Resolution> builder)
        {
            builder.Property(p => p.Date).HasColumnType("date").HasDefaultValue(DateTime.Now);
        }
    }
}
