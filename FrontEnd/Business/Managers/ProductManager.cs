using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class ProductManager : IProductService
    {
        public Task<Product> Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsByCategory(int categoryId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
