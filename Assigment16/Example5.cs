using System;
using System.Collections.Generic;

public class Smartphone : IComparable<Smartphone>
{
    public string IMEINo { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }

    public int CompareTo(Smartphone other)
    {
        return Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"{Name} (IMEI: {IMEINo}, Model: {Model}, Price: {Price})";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SortedSet<Smartphone> sortedSet = new SortedSet<Smartphone>
        {
            new Smartphone { IMEINo = "1234567890", Name = "iPhone 12", Model = "12", Price = 799.99 },
            new Smartphone { IMEINo = "2345678901", Name = "Samsung Galaxy S21", Model = "S21", Price = 799.99 },
            new Smartphone { IMEINo = "3456789012", Name = "Google Pixel 5", Model = "Pixel 5", Price = 699.99 },
            new Smartphone { IMEINo = "4567890123", Name = "OnePlus 9", Model = "9", Price = 699.99 },
            new Smartphone { IMEINo = "5678901234", Name = "Xiaomi Mi 11", Model = "Mi 11", Price = 599.99 },
        };

        Console.WriteLine("Sorted Set of Smartphones:");
        foreach (var smartphone in sortedSet)
        {
            Console.WriteLine(smartphone);
        }
        Console.ReadLine();
    }
}
