
using Communicator;
using DependencyInjection;

ICommunicator communicator = CommunicatorFactory.CreateCommunicator();

communicator.SendMessage("Charly", "Servus!");

Console.ReadLine();
