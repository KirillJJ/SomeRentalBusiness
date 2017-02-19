using Domain.Commands.CommandContext;

namespace Domain.Commands
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand<TCommandContext> Create<TCommandContext>() where TCommandContext : ICommandContext
        {
            throw new System.NotImplementedException();
        }
    }
}