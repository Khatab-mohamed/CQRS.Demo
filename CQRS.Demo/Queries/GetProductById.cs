using CQRS.Demo.Entities;
using MediatR;

namespace CQRS.Demo.Queries
{
    public record GetProductById(int id) :IRequest<Product>;
}
