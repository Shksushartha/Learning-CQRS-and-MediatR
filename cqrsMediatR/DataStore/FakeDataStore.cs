using System;
using cqrsMediatR.Models;

namespace cqrsMediatR.DataStore
{
    public class FakeDataStore
    {
        public List<Product> products;
        public FakeDataStore()
        {
            products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "sush"
            },
            new Product
            {
                Id = 2,
                Name = "sush"
            },
            new Product
            {
                Id = 3,
                Name = "sush"
            },
            new Product
            {
                Id = 4,
                Name = "sush"
            },
            new Product
            {
                Id = 5,
                Name = "sush"
            }
        };
        }


        public async Task Addproduct(Product p)
        {
            products.Add(p);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await Task.FromResult(products);
        }

        public async Task<Product> GetProductById(int id)
        {
            var p = products.FirstOrDefault(item => item.Id == id);
            return await Task.FromResult(p);
        }
    }
}

