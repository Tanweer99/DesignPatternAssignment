using NotificationSystemProject.service;
using NotificationSystemProject.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.ConcreateStrategy
{
    /// <summary>
    /// This Class represents Email Channel and and implements the method inheriting from
    /// the INotificationChannel inteface.
    /// </summary>
    internal class EmailChannelStrategy : INotificationChannelStrategy
    {
        /// <summary>
        /// A method to send message via Email. 
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public void SendMessage(string to, string subject, string message)
        {
            Console.Write($"Sending Email...\n");
            string templateMessage =
                @"Subject - {0}

                 Dear {1},
                 {2}

                 Regards";
            templateMessage = String.Format(templateMessage, subject, to, message);
            Console.WriteLine(templateMessage);
            Console.WriteLine("\nEmail sent successfully.");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
