namespace NotificationSystemProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: NotificationSystemProject <Channel> <Subject> <Message>");
                return;
            }

            string channelType = args[0];
            string subject = args[1];
            string message = args[2];

            var notificationSystem = new NotificationSystem();
            notificationSystem.SendNotifications(channelType, subject, message);
        }
    }
}