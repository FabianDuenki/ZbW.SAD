using DesignPatterns.Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Abstraction.RefinedAbstractions
{
    public class WarningNotification : Notification
    {
        public WarningNotification(INotificationSender notificationSender) : base(notificationSender)
        {
            
        }
        public override void Notify(string message)
        {
            string formattedMessage = $"Warning: {message}";
            _notificationSender.SendNotification(formattedMessage);
        }
    }
}
