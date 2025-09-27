using System;
using address;

namespace customer;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUsa()
    {
        return _address.InUsa();
    }

    public string GetInfoShipiing()
    {
        return "Ship to:\n" + _name + "\n"+ _address.GetAddress();
    }

    public string GetCustomerName()
    {
        return _name;
    }
}
