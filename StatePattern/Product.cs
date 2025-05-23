namespace StatePattern;

public class Product
{
    public int code { get; set; }
    public string name { get; set; } = "";
    public double price { get; set; }
    public Product(int code, string name, double price)
    {
        this.code = code;
        this.name = name;
        this.price = price;
    }
}
