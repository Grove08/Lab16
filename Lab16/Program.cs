using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.IO;

namespace Lab16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Product[] products= new Product[n];

            for (int i = 0; i < n; i++)
            {          

                Console.WriteLine("Код товара");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Название товара");
                string name = Console.ReadLine();
                Console.WriteLine("Цена товара");
                double price = Convert.ToDouble(Console.ReadLine());
                products[i] = new Product() {Code = code, Name = name, Price = price};
            }


            string jsonString = JsonSerializer.Serialize(products);

            using (StreamWriter sw = new StreamWriter("../../../Products.json"))
            {
                sw.WriteLine(jsonString); 
            }
        }
    }
}
