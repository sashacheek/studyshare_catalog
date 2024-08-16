using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Models
{
    public class ConfigureTeachers : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> entity)
        {
            entity.HasData(
                new { TeacherId = 1, FirstName = "Sasha", LastName = "Cheek" },
                new { TeacherId = 2, FirstName = "Jenna", LastName = "Hillman" },
                new { TeacherId = 3, FirstName = "Bryson", LastName = "Keightley" },
                new { TeacherId = 4, FirstName = "Annika", LastName = "Creste" },
                new { TeacherId = 5, FirstName = "Andrew", LastName = "Brooks" },
                new { TeacherId = 6, FirstName = "Mark", LastName = "Templeton" }
                );
        }
    }
}
