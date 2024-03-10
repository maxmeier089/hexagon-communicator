using Communicator;

namespace Adapter
{
    public class TestMessageSenderAdapter
    {

        private string name;

        private IMessageInputPort messageInputPort;

        static Random random = new Random();


        public TestMessageSenderAdapter(string name, IMessageInputPort messageInputPort)
        {
            this.name = name;
            this.messageInputPort = messageInputPort;

            Task.Run(async () =>
            {
                int n = 0;

                while (true)
                {
                    await Task.Delay(random.Next(500, 3000));

                    messageInputPort.SendMessage(name, "Test Message " + ++n);   
                }
            });
        }

    }
}
