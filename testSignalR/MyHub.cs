using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.SignalR;

namespace testSignalR
{
    public class MyHub : Hub
    {
        public void Announce(string message)
        {
            Clients.All.Announce(message + " changed");
        }

    }
}