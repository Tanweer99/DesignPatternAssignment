using NotificationSystemProject.Adapter;
using NotificationSystemProject.AdapterInterface;
using NotificationSystemProject.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.Facade
{
    /// <summary>
    /// A facade class that encapsulates the complexity of working with different 
    /// notification channels.
    /// </summary>
    public class NotificationService
    {
        private INotificationChannelStrategy _notificationChannelStrategy;
        public NotificationService(INotificationChannelStrategy notificationChannelStrategy)
        {
            _notificationChannelStrategy = notificationChannelStrategy;
        }
        /// <summary>
        /// A method to send notification via specific channels like Email or SMS or other potential channels.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public void SendNotification(string to, string subject, string message)
        {
            _notificationChannelStrategy.SendMessage(to, subject, message);
        }
    }
}
