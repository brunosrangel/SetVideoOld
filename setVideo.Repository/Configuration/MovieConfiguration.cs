using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setVideo.Model;

namespace setVideo.Repository.Configuration
{
    public class MovieConfiguration :  IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(c => c.id);
            builder.Property(c => c.movieName);
            builder.Property(c => c.amount);
            builder.Property(c => c.active);
        }
    }
}
