using DesignPatterns.Bridge.Abstraction;
using DesignPatterns.Bridge.Implementation.ConcreteImplementations;
using DesignPatterns.Tests.Helpers;
using Moq;

namespace DesignPatterns.Tests.Bridge
{
    public class NotificationSenderTests
    {
        [Fact]
        public void EmailNotificationSender_ShouldWriteExpectedMessage()
        {
            // Arrange
            var sender = new EmailNotificationSender();
            var expectedMessage = "Test email message";

            using var consoleOutput = new ConsoleOutputCapture();

            // Act
            sender.SendNotification(expectedMessage);

            // Assert
            var output = consoleOutput.GetOutput();
            Assert.Contains("Sending email notification: " + expectedMessage, output);
        }

        [Fact]
        public void HttpNotificationSender_ShouldWriteExpectedMessage()
        {
            // Arrange
            var sender = new HttpNotificationSender();
            var expectedMessage = "Test HTTP message";

            using var consoleOutput = new ConsoleOutputCapture();

            // Act
            sender.SendNotification(expectedMessage);

            // Assert
            var output = consoleOutput.GetOutput();
            Assert.Contains("Sending message via Rest API to Dashboarding Application: " + expectedMessage, output);
        }
    }
}
