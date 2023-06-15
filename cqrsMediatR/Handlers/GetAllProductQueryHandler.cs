using System;
using cqrsMediatR.DataStore;
using cqrsMediatR.Models;
using cqrsMediatR.Queries;
using MediatR;

namespace cqrsMediatR.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetAllProductQueryHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetAllProduct();
        }
    }
}

