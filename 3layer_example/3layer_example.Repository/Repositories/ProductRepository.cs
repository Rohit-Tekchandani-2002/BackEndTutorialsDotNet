using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3layer_example.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
        }
        private readonly DataContext _context;

    //    public ProductRepository(DataContext context)
    //    {
    //        _context = context;
    //    }

    //    public Product GetById(int id)
    //    {
    //        return _context.Products.FirstOrDefault(p => p.Id == id);
    //    }

    //    public List<Product> GetAll()
    //    {
    //        return _context.Products.ToList();
    //    }

    //    public void Create(Product product)
    //    {
    //        _context.Products.Add(product);
    //        _context.SaveChanges();
    //    }

    //    public void Update(Product product)
    //    {
    //        _context.Products.Update(product);
    //        _context.SaveChanges();
    //    }

    //    public void Delete(int id)
    //    {
    //        var product = GetById(id);
    //        if (product != null)
    //        {
    //            _context.Products.Remove(product);
    //            _context.SaveChanges();
    //        }
    //    }
    }
}
