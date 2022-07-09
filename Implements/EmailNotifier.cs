using System;
using NotificationExample.Interfaces;

namespace NotificationExample.Implements
{
    public class EmailNotifier : INotificationSender
    {
        public EmailNotifier()
        {
            IsActive = true;
        }

        public bool IsActive { get; set; }

        public void ChangeActiveStatus()
        {
            IsActive = !IsActive;
        }

        public void Send(string message)
        {
            Console.WriteLine("email=> " + message);
        }
    }
}

