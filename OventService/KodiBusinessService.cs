using KodiRpc;
using KodiRpc.List;
using KodiRpc.Video.Fields;
using System.Linq;
using System.Threading.Tasks;

namespace OventService
{
    public class KodiBusinessService
    {
        private Client kodiClient = new Client(new ConnectionSettings("192.168.1.43", 80, "", ""), new PlatformServices());

        public async Task<bool> PlayMovieAsync(string movieName)
        {
            string lowerMovieName = movieName.ToLower();
            var movies = await kodiClient.VideoLibrary.GetMovies(new Movie { MovieItem.title, MovieItem.originaltitle }, new Limits { start = 0, end = 10000 }, new Sort { method = Sort_method.title, ignorearticle = true, order = Sort_order.ascending });
            var movie = movies.movies.FirstOrDefault(x => x.title.ToLower().Contains(lowerMovieName) || x.title.ToLower().Contains(lowerMovieName));
            if (movie == null) return false; 
            await kodiClient.Playlist.Clear(1);
            await kodiClient.Playlist.Insert(1, 0, new KodiRpc.Playlist.ItemMovieid { movieid = movie.movieid });
            await kodiClient.Player.Open(new KodiRpc.Player.Open_item1 { playlistid = 1, position = 0});
            return true;
        }
    }


}
