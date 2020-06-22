using setVideo.Model;

namespace setVideo.Repository
{
    public class LocationRepository : BaseRepository<setVideoContext, Location>, ILocationRepository
    {
        public LocationRepository(setVideoContext contexto)
        {
            DataContext = contexto;
            DbSet = DataContext.Set<Location>();
        }
    }

    public interface ILocationRepository : IBaseRepository<Location>
    {
    }
}
