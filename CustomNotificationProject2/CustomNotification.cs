using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNotificationProject2
{
    internal class CustomNotification
    {
        // Delegate definition
        public delegate void Notify();

        // Event declaration
        public event Notify CustomNotificationEvent;

        // Property definition
        public string Notification { get; private set; }

        // Method to handle subscription
        private void OnSubscribe()
        {
            Notification = "Subscribed to custom notification";
        }

        // Method to handle unsubscription
        private void OnUnsubscribe()
        {
            Notification = "Unsubscribed to custom notification";
        }

        // Method to manage subscription based on notify parameter
        public void CustomNotificationSubscription(bool notify)
        {
            // Delist the previous subscriptions
            CustomNotificationEvent -= OnSubscribe;
            CustomNotificationEvent -= OnUnsubscribe;

            // Subscribe based on the notify parameter
            if (notify)
            {
                CustomNotificationEvent += OnSubscribe;
            }
            else
            {
                CustomNotificationEvent += OnUnsubscribe;
            }

            // Invoke the event to trigger the subscription method
            CustomNotificationEvent?.Invoke();
        }
    }
}
