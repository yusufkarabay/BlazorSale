using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal=productDal;
        }

        public Product Add(Product product)
        {
           return _productDal.Add(product);
        }

        public void Delete(Product product)
        {
          _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
           return _productDal.GetList();
        }

        public Product GetById(int id)
        {
           return _productDal.Get(p => p.Id == id);
        }

        public List<Product> GetProductsByCategory(int categoryId, int skip, int take)
        {
           return _productDal.GetProductsByCategory(categoryId,skip,take);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
