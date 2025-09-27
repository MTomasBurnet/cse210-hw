using System;

namespace address;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUsa()
    {
        bool inCountry = false;

        if (_country == "USA" || _country == "United State")
        {
            inCountry = true;
        }

        return inCountry;
    }

    public string GetAddress()
    {
        return _street + "\n" + _city + "\n" + _state + "," + _country;
    }


}