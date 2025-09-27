using System;

namespace product;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    private int order;

    public Product(string name, int id, double price)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = 0;
    }

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double price = _price;
        return price * _quantity;
    }

    public string GetNameProduct()
    {
        return _name;
    }

    public int GetId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

}

