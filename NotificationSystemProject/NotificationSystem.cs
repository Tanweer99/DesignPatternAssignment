using NotificationSystemProject.DatabaseLayer;
using NotificationSystemProject.Facade;
using NotificationSystemProject.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject
{
    public class NotificationSystem
    {
        private readonly UserDatabase _userDatabase;
        private readonly NotificationChannelFactory _notificationChannelFactory;
        public NotificationSystem()
        {
            _userDatabase = new UserDatabase();
            _notificationChannelFactory = NotificationChannelFactory.Instance;  
        }

        public void SendNotifications(string channelType, string subject, string message)
        {
            var subscribedUsers = _userDatabase.GetSubscribedUsers();
            var notificationChannel =  _notificationChannelFactory.CreateNotificationChannel(channelType);
            if(notificationChannel == null)
            {
                Console.WriteLine("Invalid Channel Type!");
                return;
            }

            //Use this service if  sending notificaion using builtin solutions which are implemented by strategy pattern.
            NotificationService service = new NotificationService(notificationChannel);

            //Use this service if using any third party service to send notification.
            //ThirdPartyNotificationService thirdPartyService = new ThirdPartyNotificationService();

            foreach(var user in subscribedUsers)
            {
                //call this method if using NotificationService class.
                service.SendNotification(user.Name, subject, message);

                //call this method if using ThirdPartyNotificationService class.
                //thirdPartyService.SendNotification(channelType, user.Name, subject, message);
            }
        }
    }
}
