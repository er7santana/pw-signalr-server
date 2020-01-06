using Microsoft.AspNet.SignalR;

namespace PWSignalRServer.Hubs
{
    public class ChatHub : Hub
    {
        public void SaySomething(string text)
        {
            Clients.All.FalaAlgumaCoisa(text);
        }
    }
}