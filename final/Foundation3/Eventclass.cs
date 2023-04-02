using System;

public class Event
{
    private string title;
    private string description;
    private DateTime dateTime;
    private Address address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{title} - {description}\nDate: {dateTime.ToShortDateString()}\nTime: {dateTime.ToShortTimeString()}\nAddress: {address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{title} - {dateTime.ToShortDateString()}";
    }
}