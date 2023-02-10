using CQRS.Demo.Entities;
using MediatR;

namespace CQRS.Demo.Commands
{
    public record UpdateProductCommand(Product Product) : IRequest<Product>;
}
