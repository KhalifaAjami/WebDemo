using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo.Domain.Entities;

namespace WebDemo.Domain.Queries;
public record GetProductQuery(int ProductId) : IRequest<ProductDto>;

