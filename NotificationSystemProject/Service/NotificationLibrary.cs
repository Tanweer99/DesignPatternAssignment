using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.service
{
    /// <summary>
    /// A Third party Notification service  which provides functionality
    /// of sending emails and sms.
    /// </summary>
    public class NotificationLibrary
    {
        /// <summary>
        /// A method to send notification via different channels.
        /// </summary>
        /// <param name="channelType"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public void Send(string channelType, string to, string subject, string message)
        {
            // Simulated email and SMS sending logic.
            if (channelType.Equals("Email", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Sending email to: {to}");
                Console.WriteLine($"Subject: {subject}");
                Console.WriteLine($"Body: {message}");
                Console.WriteLine("Email sent successfully.");
                Console.WriteLine("--------------------------------------------");
            }
            else if(channelType.Equals("SMS", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Sending SMS to: {to}");
                Console.WriteLine($"Subject: {subject}");
                Console.WriteLine($"Body: {message}");
                Console.WriteLine("SMS sent successfully.");
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
