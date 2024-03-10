namespace Alerting
{
    public class AlertEventArgs : EventArgs
    {

        public string Message { get; }

        internal AlertEventArgs(string message)
        {
            Message = message;
        }

    }

    public class AlertingNotificationService
    {

        public static AlertingNotificationService Instance { get; }

        public event EventHandler<AlertEventArgs>? Alert;

        static Random random = new Random();


        static AlertingNotificationService()
        {
            Instance = new AlertingNotificationService();
        }

        private AlertingNotificationService()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(random.Next(3000, 5000));

                    Alert?.Invoke(this, new AlertEventArgs("YOUR PIZZA IS READY!"));
                }
            });
        }

    }
}
