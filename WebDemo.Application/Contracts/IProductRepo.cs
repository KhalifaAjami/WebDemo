using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo.Domain.Entities;

namespace WebDemo.Application.Contracts;

public interface IBaseRepo<T> where T : class
{
    void Add(T entity);
}

public interface IProductRepo : IBaseRepo<Product>
{
    Product GetProduct();
}


public interface ICategoryRepo
{

}

public interface IUnitOfWork
{
    IProductRepo Products { get; }
    ICategoryRepo Categories { get; }
    void SaveChanges();
}