using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeleniumTracker.Models;

namespace SeleniumTracker.Entities.Configurations
{
    public class AutotestConfig : IEntityTypeConfiguration<Autotest>
    {
        public void Configure(EntityTypeBuilder<Autotest> builder)
        {
            builder.Property(p => p.Package).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Class).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Failing).HasDefaultValue(false);
        }
    }
}
