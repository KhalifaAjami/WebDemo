using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo.Application.Contracts;

namespace WebDemo.Application.Service;
internal class ProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    void AddProduct()
    {
        _unitOfWork.Products.Add()
        // check for category
        // new ProductREpro(db)
    }

    void UpdateProduct()
    {

        var product = _unitOfWork.Products.GetProduct();
        //dsadsad
    }
}
