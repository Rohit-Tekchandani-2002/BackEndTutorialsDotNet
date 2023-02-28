using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3layer_example.Entities;

namespace _3layer_example.Repositories
{
    internal interface IProductRepository
    {
        Product GetById(int id);

        List<Product> GetAll();

        void Create(Product product);

        void Update(Product product);

        void Delete(int id);
    }
}
