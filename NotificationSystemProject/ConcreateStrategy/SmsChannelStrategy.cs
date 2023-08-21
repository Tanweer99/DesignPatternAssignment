using NotificationSystemProject.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.ConcreateStrategy
{
    /// <summary>
    /// This Class represents SMS channel and and implements the method inheriting from
    /// the INotificationChannel inteface.
    /// </summary>
    internal class SmsChannelStrategy : INotificationChannelStrategy
    {
        /// <summary>
        /// A method to send message via SMS.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public void SendMessage(string to, string subject, string message)
        {
            Console.Write($"Sending SMS...\n");
            string templateMessage =
                @"Subject - {0}

                 Dear {1},
                 {2}

                 Regards";
            templateMessage = String.Format(templateMessage, subject, to, message);
            Console.WriteLine(templateMessage);
            Console.WriteLine("\nSMS sent successfully.");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
