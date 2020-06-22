using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setVideo.Model;

namespace setVideo.Repository.Configuration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Location");
            builder.HasKey(c => c.id);
            builder.Property(c => c.locationDate);
            builder.Property(c => c.locationDevolution);
            builder.Property(c => c.locationReturned);

        }
    }
}