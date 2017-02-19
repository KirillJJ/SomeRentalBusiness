﻿using Domain.Commands.CommandContext;

namespace Domain.Commands
{
    public interface ICommandFactory
    {
        ICommand<TCommandContext> Create<TCommandContext>()
            where TCommandContext : ICommandContext;
    }
}
