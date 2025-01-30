public class Order
{
    private Customer _customer;
    private List<Product> _productsOrdered = new List<Product>();
    
    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _productsOrdered.Add(product);
    }
    
    public decimal CalculateOrderCost()
    {
        decimal cost = 0m;
        foreach (Product product in _productsOrdered)
        {
            cost += product.GetProductCost();
        }
        if (_customer.InUsa())
        {
            cost += 5m;
        }
        else
        {
            cost += 35m;
        }
        return cost;
    }
    
    public string GetPackingLabel()
    {
        string packingLabel = "";
        string result = "Order Packing Label:\n";
        
        foreach (Product product in _productsOrdered)
        {
            packingLabel = $"{product.GetProductInfo()}";
            result += packingLabel;
            result += "\n";
        }
        return result;
    }
    
    public string GetShippingLabel()
    {
        return $"Order Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().Display()}";
    }
    
    public void Display()
    {
        Console.WriteLine($"The order's total cost is ${CalculateOrderCost()}");
    }
}