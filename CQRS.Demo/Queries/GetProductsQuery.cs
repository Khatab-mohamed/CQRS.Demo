using CQRS.Demo.Entities;
using MediatR;

namespace CQRS.Demo.Queries
{
    public record GetProductsQuery :IRequest<IEnumerable<Product>>;
}
