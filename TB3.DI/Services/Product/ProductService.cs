namespace TB3.DI.Services.Product;

public class ProductService : IProductService
{
    private static readonly List<ProductResponseModel> _products = new();
    private static int _nextId = 1;
    
    public Task<ProductResponseModel> GetProductAsync(int id)
    {
        var product = _products.FirstOrDefault(p => p.ProductId == id);
        return Task.FromResult(product);
    }
}