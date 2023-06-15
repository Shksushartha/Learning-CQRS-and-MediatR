using System;
using cqrsMediatR.DataStore;
using cqrsMediatR.Models;
using cqrsMediatR.Queries;
using MediatR;

namespace cqrsMediatR.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
    {
        private readonly FakeDataStore fakeDataStore;

        public GetProductByIdHandler(FakeDataStore fakeDataStore)
        {
            this.fakeDataStore = fakeDataStore;
        }

        public Task<Product> Handle(GetProductById request, CancellationToken cancellationToken)
        {
            var p = fakeDataStore.products.FirstOrDefault(item => item.Id == request.id);
            return Task.FromResult(p);
        }
    }
}

