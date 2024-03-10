namespace Communicator
{
    public interface IMessageDisplay
    {

        void DisplayMessage(string sender, string message);

        void DisplayAlert(string message);

    }
}
