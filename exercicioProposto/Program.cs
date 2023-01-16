using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioProposto.Entities;

namespace exercicioProposto
{
    class Program
    {
        static void Main(string[]args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i<=n;i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)?");
                string op = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(op == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                } else if (op == "i")
                {
                    Console.Write("Customs fee: ");
                    double CustomsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, CustomsFee));
                } else
                {
                    products.Add(new Product(name, price));
                }               
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
