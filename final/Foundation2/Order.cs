class Order
{
    List<Product> productsList = new List<Product>();
    private int _oneTimeShipping;

    Customer customer = new Customer();

    public int GetTotalCostOfOrder()
    {
        int totalCost = 0;
        foreach (Product product in productsList)
        {
            totalCost += product.GetTotalCost();
        }
        if (customer.inUSA() == true)
        {
            _oneTimeShipping = 5;
        }
        if (customer.inUSA() == false)
        {
            _oneTimeShipping = 35;
        }
        return totalCost;
    }

public void PrintPackagingLabel()
    {
      foreach (Product product in productsList)
        {
            Console.WriteLine($"{product.GetName()} - {product.GetProductID()}");
        }  
    }

public void PrintShippingLabel(Customer customer)
    {
        Console.WriteLine($"{customer.GetName}\n{customer.GetAddress1().GetAddress2}");
    }
}