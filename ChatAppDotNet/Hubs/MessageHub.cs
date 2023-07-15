using ChatAppDotNet.Models;
using Microsoft.AspNet.SignalR;

namespace ChatAppDotNet.Hubs
{
    public class MessageHub : Hub
    {
        public async Task NewMessage(Message message)
        {
            await Clients.All.SendAsync("MessageReceived", message);
        }
    }
}
