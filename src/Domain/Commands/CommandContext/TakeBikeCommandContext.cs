using Domain.Entities;
using Domain.Entities.Deposits;

namespace Domain.Commands.CommandContext
{
    public class TakeBikeCommandContext : ICommandContext
    {
        public Bike Bike { get; protected set; }
        public Client Client { get; protected set; }
        public Deposit Deposit { get; protected set; }

        public TakeBikeCommandContext(Bike bike, Client client, Deposit deposit)
        {
            Bike = bike;
            Client = client;
            Deposit = deposit;
        }
    }
}