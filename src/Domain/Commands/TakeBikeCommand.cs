using Domain.Commands.CommandContext;
using Domain.Services;

namespace Domain.Commands
{
    public class TakeBikeCommand : ICommand<TakeBikeCommandContext>
    {
        private readonly IRentService _service;

        public TakeBikeCommand(IRentService service)
        {
            _service = service;
        }

        public void Execute(TakeBikeCommandContext commandContext)
        {
            _service.Take(commandContext.Client, commandContext.Bike, commandContext.Deposit);
        }
    }
}