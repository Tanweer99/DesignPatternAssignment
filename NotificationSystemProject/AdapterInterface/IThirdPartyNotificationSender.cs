using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.AdapterInterface
{
    /// <summary>
    /// The ITarget interface defines the domain specific interface used by the client code.
    /// This needs to be implemanted by the adapter.
    /// </summary>
    public interface IThirdPartyNotificationSender
    {
        void ProcessNotification(string channelType, string to, string subject, string message);
    }
}
