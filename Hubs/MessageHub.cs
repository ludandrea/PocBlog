using Blog.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Blog.Hubs
{
    public class MessageHub : Hub
    {
        public async Task NewMessage(Message msg)
        {
            await Clients.All.SendAsync("MessageReceived", msg);
        }
    }
}