using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;
using WebApplication3.Chat;

[assembly: WebActivator.PreApplicationStartMethod(typeof(SignalR.StockTicker.RegisterHubs), "Start")]

namespace SignalR.StockTicker
{
    public static class RegisterHubs
    {
        public static void Start()
        {
            // Register the default hubs route: ~/signalr/hubs
            RouteTable.Routes.MapConnection<ChatConnection>("Chat", "chat/{*operation}");
            RouteTable.Routes.MapHubs();
        }
    }
}
