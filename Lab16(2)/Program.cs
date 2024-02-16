using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Schema;

namespace Lab16_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product mostExpensiveProduct = products[0];
            foreach (Product e in products)
            {
                if (e.Price > mostExpensiveProduct.Price)
                {
                    mostExpensiveProduct = e;
                }
            }
            Console.WriteLine($"{mostExpensiveProduct.Code} {mostExpensiveProduct.Name} {mostExpensiveProduct.Price}");
            Console.ReadKey();
        }
    }
}
