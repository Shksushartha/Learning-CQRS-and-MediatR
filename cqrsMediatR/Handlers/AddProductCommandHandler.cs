using System;
using cqrsMediatR.Commands;
using cqrsMediatR.DataStore;
using MediatR;

namespace cqrsMediatR.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly FakeDataStore fakeDataStore;

        public AddProductCommandHandler(FakeDataStore fakeDataStore)
        {
            this.fakeDataStore = fakeDataStore;
        }

        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await fakeDataStore.Addproduct(request.product);
            return Unit.Value;
        }
    }
}

