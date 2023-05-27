using System;
using System.Collections;


public class Product
{
    private int _productID;
    private string _productName;
    private double _price;
    private int _quantity;

    public Product(int productID, int quantity)
    {
        _productID = productID;
        _quantity = quantity;
    }

    public Product(int productID, string product, double cost, int quantity)
    {
        _productID = productID;
        _productName = product;
        _price = cost;
        _quantity = quantity;

    }
    public string getProduct()
    {
        return $"-- Product ID: {_productID}, item: {_productName}, quantity: {_quantity} ";
    }
    public double totalCost()
    {
        double total = _quantity * _price;
        return total;
    }
    

}


