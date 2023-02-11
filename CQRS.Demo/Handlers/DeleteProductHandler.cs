using CQRS.Demo.Commands;
using CQRS.Demo.DataStore;
using MediatR;

namespace CQRS.Demo.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly FakeDataStore _fakeDataStore;

        public DeleteProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.DeleteProduct(request.id);
            return Unit.Value;
        }
    }
}
