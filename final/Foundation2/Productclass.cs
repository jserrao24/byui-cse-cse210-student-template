
using System;

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return this.address.IsInUSA();
    }

    public string GetName()
    {
        return this.name;
    }

    public Address GetAddress()
    {
        return this.address;
    }
}

public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetPrice()
    {
        return this.price * this.quantity;
    }

    public string GetName()
    {
        return this.name;
    }

    public int GetProductId()
    {
        return this.productId;
    }

    public int GetQuantity()
    {
        return this.quantity;
    }
}

public class Order
{
    private Customer customer;
    private Product[] products;
    private const double USA_SHIPPING_COST = 5;
    private const double INTERNATIONAL_SHIPPING_COST = 35;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in this.products)
        {
            totalCost += product.GetPrice();
        }

        if (this.customer.IsInUSA())
        {
            totalCost += USA_SHIPPING_COST;
        }
        else
        {
            totalCost += INTERNATIONAL_SHIPPING_COST;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in this.products)
        {
            packingLabel += $"{product.GetName()}, Product ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{this.customer.GetName()}\n{this.customer.GetAddress().GetFullAddress()}";
    }
}