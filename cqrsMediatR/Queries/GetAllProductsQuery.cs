using System;
using cqrsMediatR.Models;
using MediatR;

namespace cqrsMediatR.Queries
{
    public record GetAllProductsQuery : IRequest<IEnumerable<Product>>;
}

