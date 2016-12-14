using KodiRpc;
using KodiRpc.List;
using KodiRpc.Video.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace HouseOvent.Business
{
    public class KodiBusinessService
    {
        private Client kodiClient = new Client(new ConnectionSettings("192.168.1.3", 80, "", ""), new PlatformServices());

        public async Task PlayMovie(string movieName)
        {
            var activePlayers = await kodiClient.Player.GetPlayers();
            var movies = await kodiClient.VideoLibrary.GetMovies(new Movie { MovieItem.title, MovieItem.originaltitle, MovieItem.file }, new Limits { start = 0, end = 10000 }, new Sort { method = Sort_method.title, ignorearticle = true, order = Sort_order.ascending });
            var movie = movies.movies.FirstOrDefault(x => x.title == movieName || x.originaltitle == movieName);
            await kodiClient.Player.Open(new KodiRpc.Player.Open_item2 { path = movie.file});
        }
    }


}
