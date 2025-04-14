using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace DataAccessLayer.RepositoryContracts;

public interface IProductsRepository
{
    /// <summary>
    /// Get all products from the database
    /// </summary>
    /// <returns>All products</returns>
    Task<IEnumerable<Product>> GetAllProduct();

    /// <summary>
    /// Retrieves all products based on the specified condition asynchronously.
    /// </summary>
    /// <param name="conditionExpression"></param>
    /// <returns> Return a collection of matching products  </returns>
    Task<IEnumerable<Product?>>
    GetProductByCondition
    (Expression<Func<Product, bool>> conditionExpression);

    /// <summary>
    /// Add a new product to the database
    /// </summary>
    /// <returns>Return the product if the function was success, if not it will return null</returns>
    Task<Product?> AddlProduct(Product product);

    /// <summary>
    /// Update a new product to the database
    /// </summary>
    /// <returns>Return the product if the function was success, if not it will return null</returns>
    Task<Product?> UpdateProduct(Product product);

    /// <summary>
    /// Delete a new product to the database
    /// <param name="productID"></param>
    /// </summary>
    /// <returns>Return the product if the function was success, if not it will return null</returns>
    Task<bool> DeleteProduct(Guid productID);



}

