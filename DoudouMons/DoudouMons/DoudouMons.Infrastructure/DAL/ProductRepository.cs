using DoudouMons.Core.interfaces;
using DoudouMons.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Infrastructure.DAL
{
    public class ProductRepository : IProductRepository
    {
        DoudouContext context = new DoudouContext();

        public object Products => throw new NotImplementedException();

        public void Add(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public void Edit(Product p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int idProduct)
        {
            Product p = context.Products.Find(idProduct);
            context.Products.Remove(p);
            context.SaveChanges();
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products;
        }

        public Product FindById(int idProduct)
        {
            var product = (from r in context.Products where r.idProduct == idProduct select r).FirstOrDefault();
            return product;
        }
    }
}
