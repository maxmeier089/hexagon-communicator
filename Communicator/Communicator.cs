namespace Communicator
{
    public class Communicator : ICommunicator
    {

        private IMessageDisplay messageDisplay;

        public void SendMessage(string sender, string message)
        {
            messageDisplay.DisplayMessage(sender, message);
        }

        public void Alert(string messsage)
        {
            messageDisplay.DisplayAlert(messsage);
        }

        public Communicator(IMessageDisplay messageDisplay)
        {
            this.messageDisplay = messageDisplay;
        }

    }
}
