using NotificationSystemProject.Adapter;
using NotificationSystemProject.AdapterInterface;
using NotificationSystemProject.ConcreateStrategy;
using NotificationSystemProject.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.Factory
{
    /// <summary>
    /// This singleton factory class is used to encapsulate the channels object creation process.
    /// </summary>
    public sealed class NotificationChannelFactory
    {
        private static NotificationChannelFactory? _instance = null;
        private static readonly object _lock = new object();
        // Made private to inhibit the object creation throuh new keyword.
        private NotificationChannelFactory() { }

        public static NotificationChannelFactory Instance
        {
            get
            {
                //incorporated issue related to multi threads trying to create objects.
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new NotificationChannelFactory();
                        }
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// A method to create instances of notification channels based on the channel type.
        /// </summary>
        /// <param name="channelType"></param>
        /// <returns>instances of notification channels</returns>
        public INotificationChannelStrategy? CreateNotificationChannel(string channelType)
        {
            if (channelType.Equals("Email", StringComparison.OrdinalIgnoreCase))
            {
                return new EmailChannelStrategy();
            }
            else if (channelType.Equals("SMS", StringComparison.OrdinalIgnoreCase))
            {
                return new SmsChannelStrategy();
            }
            else
            {
                return null;
            }
        }
    }
}
