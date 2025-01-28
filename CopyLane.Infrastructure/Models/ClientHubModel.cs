using Microsoft.AspNetCore.SignalR.Client;

namespace CopyLane.Infrastructure.Models
{
    public class ClientHubModel
    {
        public bool IsSuccessful { get; set; }

        public string Message { get; set; }

        public HubConnection HubConnection { get; set; }
    }
}
