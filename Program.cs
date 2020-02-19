#nullable enable
using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new Person(null);
            Console.WriteLine(person.MyAddress.ZipCode); 
        }
    }
}

class Person
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public Address MyAddress { get; set; }

    public Person(Address address)
    {
        MyAddress = address;
    }
}

class Address
{
    public string City { get; set; }

    public string? ZipCode { get; set; }

}


#nullable restore