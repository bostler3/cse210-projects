public class Product
{
    private string _name;
    private string _productID;
    private decimal _price; // A Bing search says the 'decimal' data type is best for financial/money calculations because of higher precision.
    private int _quantity;
    
    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
    public string GetProductInfo()
    {
        return $"{_name} {_productID}";
    }
    
    public decimal GetProductCost()
    {
        return _price * _quantity;
    }
}