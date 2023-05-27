using System;
using System.Collections;

class Customer
{
    private string _customerName;
    private Address _address;
    private string _addressstring;

    public Customer(string name, Address _address)
    {
        _customerName = name;
        _addressstring = $"{_address._addString}";

    }
    

    public string getName()
    {
        return $"{_customerName}";
    }
    public string getAddy()
    {
        return $"{_addressstring}";
    }
}