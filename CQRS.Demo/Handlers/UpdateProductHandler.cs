using CQRS.Demo.Commands;
using CQRS.Demo.DataStore;
using CQRS.Demo.Entities;
using MediatR;

namespace CQRS.Demo.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public UpdateProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.UpdateProduct(request.Product);
            return request.Product;
        }
    }
}
