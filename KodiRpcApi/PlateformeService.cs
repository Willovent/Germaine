using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace KodiRpc
{
    public class PlatformServices : IPlatformServices
    {
        private readonly IConnectionStatus _connectionStatus;

        public ISocketFactory SocketFactory { get; private set; }

        public PlatformServices()
        {
            SocketFactory = new SocketFactory();
        }

        public async Task<Stream> GetRequestStream(WebRequest request)
        {
            try
            {
                return await request.GetRequestStreamAsync();
            }
            catch (Exception ex)
            {
                _connectionStatus.SetError(ex.Message);
                throw;
            }
        }

        public async Task<WebResponse> GetResponse(WebRequest request)
        {
            using (_connectionStatus.GetProgressToken())
            {
                try
                {
                    return await request.GetResponseAsync();
                }
                catch (Exception ex)
                {
                    _connectionStatus.SetError(ex.Message);
                    throw;
                }
            }
        }

        private async Task<string> GetInternal(string uri)
        {
            using (_connectionStatus.GetProgressToken())
            {
                try
                {
                    HttpWebRequest request = WebRequest.CreateHttp(uri);
                    request.Accept = "application/json";
                    var response = await request.GetResponseAsync();
                    var stream = response.GetResponseStream();
                    var reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    return json;
                }
                catch (Exception ex)
                {
                    _connectionStatus.SetError(ex.Message);
                    throw;
                }
            }
        }

        private class NoProgressToken : IDisposable
        {
            public void Dispose()
            {
            }
        }

        private class NoConnectionStatus : IConnectionStatus
        {
            private static readonly NoProgressToken _token = new NoProgressToken();

            public IDisposable GetProgressToken()
            {
                return _token;
            }

            public void SetError(string message)
            {
            }
        }
    }

    public interface IConnectionStatus
    {
        IDisposable GetProgressToken();
        void SetError(string message);
    }

}
