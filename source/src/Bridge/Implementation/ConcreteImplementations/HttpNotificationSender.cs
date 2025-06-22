using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Implementation.ConcreteImplementations
{
    public class HttpNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending message via Rest API to Dashboarding Application: " + message);
        }
    }
}
