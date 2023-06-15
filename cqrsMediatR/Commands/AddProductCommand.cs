using System;
using cqrsMediatR.Models;
using MediatR;

namespace cqrsMediatR.Commands
{
    public record AddProductCommand(Product product) : IRequest<Unit>;
}

