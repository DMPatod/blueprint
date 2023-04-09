using MediatR;

namespace Blueprint.Domain.Core.Messages
{
    public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, bool>
        where TCommand : ICommand
    {
    }

    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {
    }
}
