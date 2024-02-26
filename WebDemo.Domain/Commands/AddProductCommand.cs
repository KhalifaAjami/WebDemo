using MediatR;

namespace WebDemo.Domain.Commands;
public class AddProductCommand : IRequest
{
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
}
