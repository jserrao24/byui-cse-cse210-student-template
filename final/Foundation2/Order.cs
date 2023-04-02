using System;

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