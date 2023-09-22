using Integration.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Integration.Infrastructure;

public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasNoKey();

        builder.ToTable(TableNames.Employees);
        
        builder.Property(employee => employee.PayrollNumber)
            .IsRequired(true);

        builder.Property(employee => employee.Surname)
            .HasMaxLength(100)
            .IsRequired(true);

    }
}
