using DesignPatterns.Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Abstraction.RefinedAbstractions
{
    public class ErrorNotification : Notification
    {
        public ErrorNotification(INotificationSender notificationSender) : base(notificationSender)
        {
            
        }
        public override void Notify(string message)
        {
            string formattedMessage = $"Error: {message}";
            _notificationSender.SendNotification(formattedMessage);
            Console.Error.WriteLine(formattedMessage);
            // Additional handling specific to Errors can be added easily here
        }
    }
}
