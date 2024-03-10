using Communicator;

namespace Adapter
{
    public class ConsoleMessageDisplayAdapter : IMessageDisplay
    {
        public void DisplayAlert(string message)
        {
            Console.WriteLine("ALERT!!! " + message);
        }

        public void DisplayMessage(string sender, string message)
        {
            Console.WriteLine(sender + ": " + message);
        }

    }
}
