using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeleniumTracker.Models;

namespace SeleniumTracker.Entities.Configurations
{
    public class CodelineConfig : IEntityTypeConfiguration<Codeline>
    {
        public void Configure(EntityTypeBuilder<Codeline> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(20).IsRequired();
        }
    }
}
