class Product
{
private string _name;
private string _productid;
private int _pricePerUnit;
private int _quantity;


public Product(string name, string productid, int priceperunit, int quantity)
    {
        _name = name; _productid = productid; _pricePerUnit = priceperunit; _quantity = quantity;
    }

public string GetName()
{
return _name;
}

public string GetProductID()
    {
        return _productid;
    }

public int GetPricePerUnit()
    {
        return _pricePerUnit;
    }

public int GetQuantity()
    {
        return _quantity;
    }

public int GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

}