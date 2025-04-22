namespace C_;

public class Inventory
{
    public Dictionary<int, Product> ProductMap { get; set; } = new Dictionary<int, Product>();
    public Dictionary<int, int> Products = new Dictionary<int, int>();

    public bool isAvailable(int productCode)
    {
        return Products.ContainsKey(productCode) && Products[productCode] > 0;
    }

    public Product GetProduct(int productCode)
    {
        return ProductMap[productCode];
    }

    public void AddProduct(Product product, int quantity)
    {
        if (!Products.ContainsKey(product.code))
        {
            Products.Add(product.code, 0);
        }
        Products[product.code] += quantity;
        if(!ProductMap.ContainsKey(product.code)) ProductMap[product.code] = product;
    }
}
