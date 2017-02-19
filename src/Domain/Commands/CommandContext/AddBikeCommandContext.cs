namespace Domain.Commands.CommandContext
{
    public class AddBikeCommandContext : ICommandContext
    {
        public string Name { get; protected set; }
        public decimal HourCost { get; protected set; }

        public AddBikeCommandContext(string name, decimal hourCost)
        {
            Name = name;
            HourCost = hourCost;
        }
    }
}