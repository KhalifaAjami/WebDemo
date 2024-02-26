using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo.Domain.Commands;

namespace WebDemo.Application.Features.Commands;
internal class AddProductHandler : IRequestHandler<AddProductCommand>
{
    private readonly ILogger<AddProductHandler> _logger;

    public AddProductHandler(ILogger<AddProductHandler> logger)
    {
        _logger = logger;
    }

    public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Product Added");
    }
}
