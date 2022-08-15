using ShoppingCartExample.Data;
using ShoppingCartExample.Models.Domain;

namespace ShoppingCartExample.Services
{
    public interface IProductService
    {
        Task<Product?> GetProduct(string id);
        Task<List<Product>> GetAllProducts();
        void AddProduct(Product product);
        void RemoveProduct(Product product);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product?> GetProduct(string id) => await _productRepository.Get(id).ConfigureAwait(false);

        public async Task<List<Product>> GetAllProducts() => (await _productRepository.GetAll().ConfigureAwait(false)).ToList();

        public void AddProduct(Product product) => _productRepository.Add(product);

        public void RemoveProduct(Product product) => _productRepository.Delete(product);
    }
}
