using System;
using order;
using product;
using address;
using customer;
class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        List<Product> products = new List<Product>();

        Product shirt = new Product("Shirt", 1234, 10, 3);
        products.Add(shirt);

        Product pant = new Product("Pant", 4567, 15, 1);
        products.Add(pant);

        Address addressJhon = new Address("12 august", "Gral Alvear", "Mendoza", "Argentina");
        Customer jhon = new Customer("Jhon Burnet", addressJhon);

        Order orderJhon = new Order(jhon, products);

        orders.Add(orderJhon);

        List<Product> products2 = new List<Product>();

        Product hoodie = new Product("Hoodie", 6321, 12.5, 1);
        products2.Add(hoodie);

        Product shorts = new Product("Short", 9512, 10, 4);
        products2.Add(shorts);

        Product sneaker = new Product("Sneaker", 1597, 25, 2);
        products2.Add(sneaker);

        Address addressAna = new Address("4301 Hidden Cove Rd", "Park City", "Utah", "USA");
        Customer ana = new Customer("Ana Aguilera", addressAna);

        Order orderAna = new Order(ana, products2);

        orders.Add(orderAna);

        foreach (Order or in orders)
        {
            Console.WriteLine(or.GetPackingLabel());
            Console.WriteLine(or.GetShippingLabel() + "\n");
            Console.WriteLine("Total Price: " + or.TotalPriceOrder());
            Console.WriteLine("-----------------------------------------");
        }


    }
}