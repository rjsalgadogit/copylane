﻿using Microsoft.AspNetCore.SignalR;

namespace CopyLane.SignalR
{
    public class SignalRHub : Hub
    {
        public SignalRHub() { }

        public override async Task OnConnectedAsync()
        {
            var connectionId = Context.ConnectionId;
            await Clients.Client(connectionId).SendAsync("SetConnectionId", connectionId);
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await Clients.All.SendAsync("ReceiveMessage", "Client disconnected:", $" {Context.ConnectionId}");
        }

        public async Task SendMessage(string connectionId, string message)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveMessage", connectionId, message);
        }
    }
}