using System;

public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string zipCode;

    public Address(string streetAddress, string city, string state, string zipCode)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    public string GetAddress()
    {
        return $"{streetAddress}, {city}, {state} {zipCode}";
    }
}