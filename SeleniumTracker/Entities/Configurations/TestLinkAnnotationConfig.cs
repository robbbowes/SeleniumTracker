using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeleniumTracker.Models;

namespace SeleniumTracker.Entities.Configurations
{
    public class TestLinkAnnotationConfig : IEntityTypeConfiguration<TestLinkAnnotation>
    {
        public void Configure(EntityTypeBuilder<TestLinkAnnotation> builder)
        {
            builder.Property(p => p.GeneralWorkflow).IsRequired();
            builder.Property(p => p.SpecificWorkflow).IsRequired();
            builder.Property(p => p.Ignore).HasDefaultValue(false);
        }
    }
}
