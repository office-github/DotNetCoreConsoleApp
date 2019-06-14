using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstConsoleApp.Models
{
  public class StudentMap: IEntityTypeConfiguration<Student>
  {
    public void Configure(EntityTypeBuilder<Student> builder)
    {
      builder.HasKey(s => s.Id);
      builder.Property(s => s.Name).HasMaxLength(250);
      //builder.Property(s => s.Email).HasMaxLength(250);
    }
  }
}
