using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exam11mid
{
    public class ChatHub : Hub
    {
        public void MsgSend(string name, string message)
        {
            Clients.All.BroadcastMessage(name, message);
        }

        public void FileSend(string name, string fileName, string fileData)
        {
            Clients.All.BroadcastFile(name, fileName, fileData);
        }


    }
}