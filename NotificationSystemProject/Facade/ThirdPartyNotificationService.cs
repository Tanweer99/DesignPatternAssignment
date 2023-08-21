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
    /// A facade class that encapsulates the complexity of working with different third party
    /// notification channels.
    /// </summary>
    public class ThirdPartyNotificationService
    {
        private IThirdPartyNotificationSender thirdPartyNotificationSender;
        public ThirdPartyNotificationService()
        {
            thirdPartyNotificationSender = new NotificationSystemAdapter();
        }
        /// <summary>
        /// A method to send notification via specific channels like Email or SMS or other potential 
        /// channels based on channel type.
        /// </summary>
        /// <param name="channelType"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public void SendNotification(string channelType, string to, string subject, string message)
        {
            thirdPartyNotificationSender.ProcessNotification(channelType, to, subject, message);
        }
    }
}
