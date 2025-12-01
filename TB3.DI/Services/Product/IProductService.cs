namespace TB3.DI.Services.Product;

public interface IProductService
{
    Task<ProductResponseModel> GetProductAsync(int id);
}

public class ProductResponseModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
}