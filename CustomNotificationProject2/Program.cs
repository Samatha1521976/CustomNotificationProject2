// See https://aka.ms/new-console-template for more information
using CustomNotificationProject2;

var customNotification = new CustomNotification();

customNotification.CustomNotificationSubscription(true);
Console.WriteLine(customNotification.Notification);

customNotification.CustomNotificationSubscription(false);
Console.WriteLine(customNotification.Notification);