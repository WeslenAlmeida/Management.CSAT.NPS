using MediatR;

namespace Management.CSAT.NPS.Domain.Interfaces.v1
{
    public interface ICommand<out TRespone> : IRequest<TRespone>
    {
    }
}
