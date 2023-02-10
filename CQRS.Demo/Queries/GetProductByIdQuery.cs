using CQRS.Demo.Entities;
using MediatR;

namespace CQRS.Demo.Queries
{
    public record GetProductByIdQuery(int id) :IRequest<Product>;
}
