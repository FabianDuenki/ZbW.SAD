using DesignPatterns.Bridge.Implementation;
using DesignPatterns.Bridge.Abstraction.RefinedAbstractions;
using Moq;

namespace DesignPatterns.Tests.Bridge
{
    public class NotificationTests
    {
        [Fact]
        public void Notify_ErrorNotification_ShouldFormatMessageAndSend()
        {
            // Arrange
            var mockSender = new Mock<INotificationSender>();
            var notification = new ErrorNotification(mockSender.Object);

            // Act
            notification.Notify("Something failed.");

            // Assert
            var wasCalled = mockSender.Invocations
                .Any(inv => inv.Method.Name == nameof(INotificationSender.SendNotification)
                            && inv.Arguments[0].ToString() == "Error: Something failed.");

            Assert.True(wasCalled);
        }
        [Fact]
        public void Notify_WarningNotification_ShouldFormatMessageAndSend()
        {
            // Arrange
            var mockSender = new Mock<INotificationSender>();
            var notification = new WarningNotification(mockSender.Object);

            // Act
            notification.Notify("Something failed.");

            // Assert
            var wasCalled = mockSender.Invocations
                .Any(inv => inv.Method.Name == nameof(INotificationSender.SendNotification)
                            && inv.Arguments[0].ToString() == "Warning: Something failed.");

            Assert.True(wasCalled);
        }
        [Fact]
        public void Notify_InformationNotification_ShouldFormatMessageAndSend()
        {
            // Arrange
            var mockSender = new Mock<INotificationSender>();
            var notification = new InformationNotification(mockSender.Object);

            // Act
            notification.Notify("Something failed.");

            // Assert
            var wasCalled = mockSender.Invocations
                .Any(inv => inv.Method.Name == nameof(INotificationSender.SendNotification)
                            && inv.Arguments[0].ToString() == "Information: Something failed.");

            Assert.True(wasCalled);
        }
    }
}
