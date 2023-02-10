using CQRS.Demo.Entities;

namespace CQRS.Demo.DataStore
{
    public class FakeDataStore
    {
        private static List<Product> products;
        public FakeDataStore()
        {
            products = new List<Product>() 
            {
                new Product() {Id = 101,Name="Product 1"},
                new Product() {Id = 102,Name="Product 2"},
                new Product() {Id = 103,Name="Product 3"},
                new Product() {Id = 104,Name="Product 4"},
            };
          
        }
        public async Task AddProduct(Product product)
        {
            products.Add(product);
            await Task.CompletedTask;

        }

        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(products);

        public async Task<Product> GetProductById(int id) =>  await Task.FromResult(products.Single(p => p.Id == id));

    }
}
