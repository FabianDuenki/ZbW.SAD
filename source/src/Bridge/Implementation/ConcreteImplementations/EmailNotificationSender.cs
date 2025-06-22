using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Implementation.ConcreteImplementations
{
    public class EmailNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending email notification: " + message);
        }
    }
}
