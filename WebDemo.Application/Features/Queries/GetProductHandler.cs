using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo.Domain.Queries;

namespace WebDemo.Application.Features.Queries;
internal class GetProductHandler : IRequestHandler<GetProductQuery, ProductDto>
{
    public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        return new ProductDto()
        {
            ProductId = request.ProductId,
            ProductName = "Test"
        };
    }
}
