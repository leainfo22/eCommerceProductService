using DataAccessLayer.Entities;
using DataAccessLayer.RepositoryContracts;
using eCommerce.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.Repository;

public class ProductsRepository : IProductsRepository
{

    private readonly ApplicationDbContext _dbContext;


    // Constructor to initialize the DbContext 
    public ProductsRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<Product?> AddlProduct(Product product)
    {
        _dbContext.Products.Add(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }

    public async Task<bool> DeleteProduct(Guid productID)
    {
        Product? product = await _dbContext.Products.FirstOrDefaultAsync(p => 
            p.ProductID == productID);
        if (product != null)
            return false;
        
        _dbContext.Products.Remove(product);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public Task<IEnumerable<Product>> GetAllProduct()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product?>> GetProductByCondition(Expression<Func<Product, bool>> conditionExpression)
    {
        throw new NotImplementedException();
    }

    public Task<Product?> UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}

