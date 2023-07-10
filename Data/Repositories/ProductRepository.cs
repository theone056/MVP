using Data.Interface;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository : IProduct
    {
        ApplicationDBContext _app;
        public ProductRepository(ApplicationDBContext app)
        {
            _app = app;
        }
        public List<Product> Products()
        {
           return _app.Products.ToList();
        }
    }
}
