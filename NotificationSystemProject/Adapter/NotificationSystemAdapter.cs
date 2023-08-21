using NotificationSystemProject.AdapterInterface;
using NotificationSystemProject.ConcreateStrategy;
using NotificationSystemProject.service;
using NotificationSystemProject.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.Adapter
{
    /// <summary>
    /// The Adapter class to incorporate Third Party Notification System.
    /// The Adapter makes the Adaptee's interface compatible with the Target's interface.
    /// This is the class that makes two incompatible interfaces or systems work together.
    /// </summary>
    internal class NotificationSystemAdapter : NotificationLibrary, IThirdPartyNotificationSender
    {
        /// <summary>
        /// A method to process message to make compatible to Third Party Service interface method for processing.
        /// </summary>
        /// <param name="channelType"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public void ProcessNotification(string channelType, string to, string subject, string message)
        {
            Send(channelType, to, subject, message);
        }
    }
}
