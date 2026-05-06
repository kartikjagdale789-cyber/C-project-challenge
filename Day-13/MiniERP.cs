using System;
using System.Collections.Generic;

class Product
{
    public int Id;
    public string Name;
    public int Price;
}

class MiniERP
{
    static List<Product> products = new List<Product>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Product\n2. View Products\n3. Exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Product p = new Product();
                Console.Write("Id: "); p.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: "); p.Name = Console.ReadLine();
                Console.Write("Price: "); p.Price = int.Parse(Console.ReadLine());

                products.Add(p);
            }
            else if (choice == 2)
            {
                foreach (var p in products)
                    Console.WriteLine($"{p.Id} {p.Name} {p.Price}");
            }
            else break;
        }
    }
}