using CopyLane.Core.Services.Interfaces;
using CopyLane.SignalR;

namespace CopyLane.Core.Services
{
    public class ServerService : IServerService
    {
        private SignalRServer _signalRServer { get; set; }

        public ServerService() { }

        public void Start(string ipAddress, string port)
        {
            _signalRServer = new SignalRServer(ipAddress, port);
            _signalRServer.Start();
        }
    }
}
