using DoudouMons.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core.interfaces
{
    public interface IProductRepository
    {
        object Products { get; }

        void Add(Product p);
        void Edit(Product p);
        void Remove(int idProduct);
        Product FindById(int idProduct);
    }
}
