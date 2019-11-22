using Microsoft.AspNetCore.SignalR;
using SignalRNotificationHub.Models;
using System.Threading.Tasks;

namespace SignalRNotificationHub.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task NewNotification(Message msg)
        {
            // Send a message to all connected clients
            await Clients.All.SendAsync("MessageReceived", msg);
        }
    }
}
