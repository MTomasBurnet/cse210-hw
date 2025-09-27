using System;
using product;
using address;
using customer;

namespace order;
public class Order
{
    List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalPriceOrder()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.IsInUsa())
        {
            total += 5;
        }
        else
        {
            total += 20;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string packing = "";
        packing += "Customer: " + _customer.GetCustomerName() + "\n" + "Items:\n";

        foreach (Product product in _products)
        {
            packing += "- " + product.GetQuantity() + "x " + product.GetNameProduct() + " ID: " + product.GetId() + "\n";
        }

        return packing;
    }

    public string GetShippingLabel()
    {
        return _customer.GetInfoShipiing();
    }
}