using DesignPatterns.Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Abstraction
{
    public abstract class Notification
    {
        protected INotificationSender _notificationSender;
        public Notification(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }
        public abstract void Notify(string message);
    }
}
