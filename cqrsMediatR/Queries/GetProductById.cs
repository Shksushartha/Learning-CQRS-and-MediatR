using System;
using cqrsMediatR.Models;
using MediatR;

namespace cqrsMediatR.Queries
{
    public record GetProductById(int id) : IRequest<Product>;

}

