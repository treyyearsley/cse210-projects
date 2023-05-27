using System;
using System.Collections;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    public string _country;
    public double _shipCost;
    public string _addString;

    public Address()
    {

    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _addString = $"{_street},\n{_city}, {_state}\n{_country}";

    }
    
    public double inUS()
    {
        if(_country == "US"|| _country == "USA")
        {
            _shipCost = 5.00;
            return _shipCost;
        }
        else
        {
            _shipCost = 35.00;
            return _shipCost;
        }
    }


    public int GetShipping()
    {
        if (_country == "United States")
        {
            int _shipping = 5;
            return _shipping;
        }
        else
        {
            int _shipping = 35;
            return _shipping;
        }
    }
}
