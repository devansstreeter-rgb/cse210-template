public class Order
{
    private Customer _customer;
    private List<Product> _cart;

    public Order(Customer customer, List<Product> cart)
    {
        _customer = customer;
        _cart = cart;
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in _cart)
        {
            total += product.GetPrice() * product.GetQuant();
        }
        if (_customer.IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string labelText = "";
        foreach (Product product in _cart)
        {
            labelText += $"[x{product.GetQuant()}] {product.GetName()} - ID#{product.GetID()}\n";
        }
        return labelText;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}