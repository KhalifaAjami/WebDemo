using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebDemo.Domain.Commands;
using WebDemo.Domain.Queries;

namespace WebDemo.Api.Controllers;
[Route("[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task AddProduct(AddProductCommand command)
    {
        await _mediator.Send(command);
    }

    [HttpGet("{productId}")]
    public async Task<ProductDto> GetProduct(int productId)
    {
        return await _mediator.Send(new GetProductQuery(productId));
    }
}
