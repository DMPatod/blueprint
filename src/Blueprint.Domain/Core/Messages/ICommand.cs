using MediatR;

namespace Blueprint.Domain.Core.Messages
{
    public interface ICommand : ICommand<bool>
    {
    }

    public interface ICommand<out T> : IRequest<T>
    {
    }
}
