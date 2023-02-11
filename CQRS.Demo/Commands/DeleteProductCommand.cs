using CQRS.Demo.Entities;
using MediatR;

namespace CQRS.Demo.Commands
{
    public record DeleteProductCommand(int id) : IRequest;
}
