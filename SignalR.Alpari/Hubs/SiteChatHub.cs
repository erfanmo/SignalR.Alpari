using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalR.Alpari.Hubs
{
    public class SiteChatHub:Hub
    {
        public async Task SendNewMessage(string Sender,string Message)
        {
           await Clients.All.SendAsync("getNewMessage", Sender,Message,DateTime.Now.ToShortDateString());
        }

        public override Task OnConnectedAsync()
        {
            var s = Context.ConnectionId;
            return base.OnConnectedAsync();
        }

        //When client disconnected
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception); 
        }

    }
}
