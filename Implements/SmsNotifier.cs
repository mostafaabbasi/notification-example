using System;
using NotificationExample.Interfaces;

namespace NotificationExample.Implements
{
    public class SmsNotifier : INotificationSender
    {
        public SmsNotifier()
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
            Console.WriteLine("sms=> " + message);
        }
    }
}

