using NotificationExample.Interfaces;

string[] messages = { "m1", "m2", "m3", "m4" };

var notifires = AppDomain.CurrentDomain.GetAssemblies()
                                       .SelectMany(s => s.GetTypes())
                                       .Where(w => typeof(INotificationSender).IsAssignableFrom(w) && w.IsClass);


if (notifires is not null)
{
    List<INotificationSender> services = new List<INotificationSender>();

    foreach (var notifire in notifires)
    {
        var notifireInstance = (INotificationSender)Activator.CreateInstance(notifire);
        services.Add(notifireInstance);
    }

    services = services.Where(w => w.IsActive == true).ToList();


    for (int i = 0; i < 2; i++)
        services[0].Send(messages[i]);

    for (int i = 2; i < 4; i++)
        services[1].Send(messages[i]);

}



Console.ReadKey();