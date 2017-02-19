using Domain.Entities;

namespace Domain.Commands.CommandContext
{
    public class ReturnBikeCommandContext : ICommandContext
    {
        public Bike Bike { get; protected set; }
        public RentPoint RentPoint { get; protected set; }

        public ReturnBikeCommandContext(Bike bike, RentPoint rentPoint)
        {
            Bike = bike;
            RentPoint = rentPoint;
        }
    }
}