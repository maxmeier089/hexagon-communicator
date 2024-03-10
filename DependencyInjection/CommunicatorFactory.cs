using Adapter;
using Alerting;
using Communicator;

namespace DependencyInjection
{
    public static class CommunicatorFactory
    {

        public static ICommunicator CreateCommunicator()
        {
            Communicator.Communicator communicator = new(new ConsoleMessageDisplayAdapter());

            new TestMessageSenderAdapter("Anton", communicator);

            new TestMessageSenderAdapter("Bernd", communicator);

            new AlertingNotificationServiceAdapter(AlertingNotificationService.Instance, communicator);


            return communicator;
        }

    }
}
