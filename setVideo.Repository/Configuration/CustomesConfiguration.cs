using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setVideo.Model;

namespace setVideo.Repository.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.name).HasMaxLength(100);
            builder.Property(c => c.cpf).HasMaxLength(11);
            builder.Property(c => c.active);
            

        }
    }
}