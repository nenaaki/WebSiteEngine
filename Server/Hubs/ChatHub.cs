using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebSiteEngine.Shared;

namespace WebSiteEngine.Server
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync(ApplicationValues.HubReceiverName, user, message);
        }
    }
}