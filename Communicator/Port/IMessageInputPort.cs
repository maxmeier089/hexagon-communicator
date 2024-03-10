namespace Communicator
{
    public interface IMessageInputPort
    {

        void SendMessage(string sender, string message);

    }
}
