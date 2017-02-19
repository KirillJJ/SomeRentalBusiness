using Domain.Commands.CommandContext;
using Domain.Services;

namespace Domain.Commands
{
    public class ReturnBikeCommand : ICommand<ReturnBikeCommandContext>
    {
        private readonly IRentService _service;

        public ReturnBikeCommand(IRentService service)
        {
            _service = service;
        }

        public void Execute(ReturnBikeCommandContext commandContext)
        {
            _service.Return(commandContext.Bike, commandContext.RentPoint);
        }
    }
}