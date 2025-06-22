using DesignPatterns.Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Abstraction.RefinedAbstractions
{
    public class InformationNotification : Notification
    {
        public InformationNotification(INotificationSender notificationSender) : base(notificationSender)
        {
            
        }
        public override void Notify(string message)
        {
            string formattedMessage = $"Information: {message}";
            _notificationSender.SendNotification(formattedMessage);
        }
    }
}
