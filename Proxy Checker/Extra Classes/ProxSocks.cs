using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Threading;
using System.Security.Cryptography;
using System.Reflection;

namespace ProxSocks
{
    class ProxSocks
    {
        public TcpClient SockHTTPProxy(string host, int port, string proxHost, int proxPort, string proxUser = "", string proxPass = "")
        {
            try {
                var proxUri = new UriBuilder {
                    Scheme = Uri.UriSchemeHttp,
                    Host = proxHost,
                    Port = proxPort
                };

                var request = WebRequest.Create("http://" + host + ":" + port);
                var webProx = new WebProxy(proxUri.Uri);

                request.Proxy = webProx;
                request.Method = "CONNECT";

                if (proxUser != "" && proxPass != "" | proxUser != "")
                    webProx.Credentials = new NetworkCredential(proxUser, proxPass);

                var response = request.GetResponse();

                var respStream = response.GetResponseStream();

                const BindingFlags Flags = BindingFlags.NonPublic | BindingFlags.Instance;

                var rsType = respStream.GetType();
                var connectionProp = rsType.GetProperty("Connection", Flags);

                var connection = connectionProp.GetValue(respStream, null);
                var connectionType = connection.GetType();
                var networkStreamProp = connectionType.GetProperty("NetworkStream", Flags);

                var networkStream = networkStreamProp.GetValue(connection, null);
                var nsType = networkStream.GetType();
                var sockProp = nsType.GetProperty("Socket", Flags);
                var sock = (Socket)sockProp.GetValue(networkStream, null);

                return new TcpClient { Client = sock };
            } catch { throw; }
        }
    }
}
