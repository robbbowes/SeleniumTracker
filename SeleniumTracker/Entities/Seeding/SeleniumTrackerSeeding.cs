using Microsoft.EntityFrameworkCore;
using SeleniumTracker.Entities.Enums;
using SeleniumTracker.Models;

namespace SeleniumTracker.Entities.Seeding
{
    public static class SeleniumTrackerSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var count = 15;

            modelBuilder.Entity<Codeline>().HasData(generateCodelineData());

            modelBuilder.Entity<Autotest>().HasData(generateAutotestData(count));

            modelBuilder.Entity<TestLinkAnnotation>().HasData(generateTestLinkAnnotationData(count));

            modelBuilder.Entity<Failure>().HasData(generateFailureData(count));

            modelBuilder.Entity<Resolution>().HasData(generateResolutionData(count));
        }

        private static Codeline generateCodelineData()
        {
            return new Codeline { Id = 1, Name = "14.12" };
        }

        private static Autotest[] generateAutotestData(int count)
        {
            var autotests = new List<Autotest>();
            for (int i = 1; i < count + 1; i++)
            {
                autotests.Add(new Autotest
                {
                    Id = i,
                    Package = Faker.Lorem.Paragraph(i).Split(".")[i - 1].Trim(),
                    Class = Faker.Lorem.Paragraph(i).Split(".")[i - 1].Trim(),
                    Name = Faker.Lorem.Paragraph(i).Split(".")[i - 1].Trim(),
                    Priority = Faker.Enum.Random<Priority>(),
                    Failing = Faker.Boolean.Random(),
                    CodelineId = 1
                });
            }
            return autotests.ToArray();
        }

        private static TestLinkAnnotation[] generateTestLinkAnnotationData(int count)
        {
            var annotations = new List<TestLinkAnnotation>();
            for (int i = 1; i < count + 1; i++)
            {
                annotations.Add(new TestLinkAnnotation
                {
                    Id = i,
                    TestlinkId = "LS14-100000" + i,
                    GeneralWorkflow = Faker.Enum.Random<GeneralWorkflow>(),
                    SpecificWorkflow = Faker.Enum.Random<SpecificWorkflow>(),
                    Ignore = Faker.Boolean.Random(),
                    Comments = Faker.Lorem.Paragraph(i).Split(".")[i - 1].Trim(),
                    AutotestId = i,
                });
            }
            return annotations.ToArray();
        }

        private static Failure[] generateFailureData(int count)
        {
            var failures = new List<Failure>();
            for (int i = 1; i < count + 1; i++)
            {
                failures.Add(new Failure
                {
                    Id = i,
                    Date = DateTime.Today,
                    Details = Faker.Lorem.Paragraph(i).Split(".")[i - 1].Trim(),
                    AutotestId = i
                });
            }
            return failures.ToArray();
        }

        private static Resolution[] generateResolutionData(int count)
        {
            var resolutions = new List<Resolution>();
            for (int i = 1; i < count + 1; i++)
            {
                resolutions.Add(new Resolution
                {
                    Id = i,
                    Details = Faker.Lorem.Paragraph(i).Split(".")[i - 1].Trim(),
                    Date = DateTime.Today,
                    FailureId = i
                });
            }
            return resolutions.ToArray();
        }
    }
}
