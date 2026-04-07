class Order
{
    private List<Product> productsList = new List<Product>();
    private int _oneTimeShipping;
    private string packagingLabel;
    private Customer _customer;
    private Address _address;
    private DateTime dateTime = DateTime.Now;



    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    public DateTime GetTimeOfOrder()
    {
        return dateTime;
    }

    public int GetTotalCostOfOrder()
    {
        int totalCost = 0;
        foreach (Product product in productsList)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.inUSA() == true)
        {
            _oneTimeShipping = 5;
        }
        if (_customer.inUSA() == false)
        {
            _oneTimeShipping = 35;
        }
        totalCost += _oneTimeShipping;
        return totalCost;
    }

public string PackagingLabel()
    { 
      packagingLabel += "----------------------------------\nPackaging Label\n";
      foreach (Product product in productsList)
        {
            packagingLabel += $"{product.GetName()}({product.GetQuantity()}pcs) - {product.GetProductID()}\n";
        }  

        return packagingLabel;
    }

public string ShippingLabel(Customer customer)
    {
        return $"Shipping Label\n{customer.GetName()}\n{customer.GetAddress1().GetAddress2()}";
    }

public void AddToList(Product product)
    {
        productsList.Add(product);
    }

}