using Domain.Services;

namespace Domain.Commands.CommandContext
{
    public class AddRentPointCommand : ICommand<AddRentPointCommandContext>
    {
        private readonly IRentPointService _service;

        public AddRentPointCommand(IRentPointService service)
        {
            _service = service;
        }

        public void Execute(AddRentPointCommandContext commandContext)
        {
            _service.AddRentPoint(commandContext.Employee, commandContext.Money, commandContext.Name);
        }
    }
}