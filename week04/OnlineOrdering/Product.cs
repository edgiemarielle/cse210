public class Product
{
    private string _name = "";
    private int _productId = 0;
    private double _price = 0.0;
    private int _quantity = 0;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productId;
    }
}