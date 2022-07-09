using System;
namespace NotificationExample.Interfaces
{
    public interface INotificationSender
    {
        bool IsActive { get; set; }

        void Send(string message);

        void ChangeActiveStatus();
    }
}

