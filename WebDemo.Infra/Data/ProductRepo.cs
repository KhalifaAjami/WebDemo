using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo.Application.Contracts;
using WebDemo.Domain.Entities;

namespace WebDemo.Infra.Data;

public class BaseRepo<T> : IBaseRepo<T> where T : class
{
    private readonly DbContext _dbContext;

    public BaseRepo(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(T entity)
    {
        _dbContext.Set<T>()
                  .Add(entity);
    }
}


public class ProductRepo : BaseRepo<Product>, IProductRepo
{
    public ProductRepo(DbContext dbContext) : base(dbContext)
    {
    }

    public Product GetProduct()
    {
        return new();
    }
}

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork()// DbContext
    {
        
    }

    private IProductRepo _productRepo;
    public IProductRepo Products
    {
        get
        {
            if(_productRepo == null)
                _productRepo = new ProductRepo();

            return _productRepo;
        }
    }

    public ICategoryRepo Categories => throw new NotImplementedException();

    public void SaveChanges()
    {
        //db.SaveChanges();
    }
}