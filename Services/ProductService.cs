using SwaggerProject.Modells;

public class ProductService : IProductService
{
    public readonly List<Product> _products = new();
    public List<Product> GetProducts() => _products;
    public void Add(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
    }
}