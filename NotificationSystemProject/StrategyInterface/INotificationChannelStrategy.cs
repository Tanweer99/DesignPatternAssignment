using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.StrategyInterface
{
    /// <summary>
    /// This interface represents the notification channels (Email, SMS, and potentially others).
    /// And in terms of design pattern this interface act as strategy interface for concreate 
    /// strategies like EmailChannel and SMSChannel.
    /// </summary>
    public interface INotificationChannelStrategy
    {
        void SendMessage(string to, string subject, string message);
    }
}
