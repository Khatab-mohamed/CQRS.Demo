using CQRS.Demo.Entities;
using MediatR;

namespace CQRS.Demo.Commands
{
    public record AddProductCommand(Product Product) :IRequest;
}
