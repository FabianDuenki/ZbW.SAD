using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Implementation
{
    public interface INotificationSender
    {
        public void SendNotification(string message); 
    }
}
