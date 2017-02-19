using Domain.Services;

namespace Domain.Commands.CommandContext
{
    public class AddBikeCommand : ICommand<AddBikeCommandContext>
    {
        private readonly IBikeService _service;

        public AddBikeCommand(IBikeService service)
        {
            _service = service;
        }

        public void Execute(AddBikeCommandContext commandContext)
        {
            _service.AddBike(commandContext.Name, commandContext.HourCost);
        }
    }
}