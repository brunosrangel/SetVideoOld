using setVideo.Model;

namespace setVideo.Repository
{
    public class MovieRepository : BaseRepository<setVideoContext, Movie>, IMovieRepository
    {
        public MovieRepository(setVideoContext contexto)
        {
            DataContext = contexto;
            DbSet = DataContext.Set<Movie>();
        }

       
    }

    public interface IMovieRepository : IBaseRepository<Movie>
    {
    }
}
